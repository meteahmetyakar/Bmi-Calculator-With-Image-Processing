using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    class Database
    {
        public const string serverName = "BLUU\\SQLEXPRESS";    //server name
        public const string databaseName = "RecognizedFaces";   //database name
        public const string tableName = "persons";              //table name for person datas
        public const string tableConnString = @"Server = " + serverName + ";Database=" + databaseName + "; Trusted_Connection=yes;"; //this connection string using for connect to table with this string we can do table process as add,delete,update
        public const string dbConnString = @"Server = " + serverName + "; Trusted_Connection=yes;";     //this connection string using for connect to database with this string we can do database process as create db, drop or truncate db

        SqlConnection connnString;

        public bool createDatabase()
        {
            /*
             * This function create a new database
             */

            string sqlCreateDBQuery;

            connnString = new SqlConnection(dbConnString);


            sqlCreateDBQuery = "CREATE DATABASE " + databaseName + " ; ";
            SqlCommand command = new SqlCommand(sqlCreateDBQuery, connnString);
            try
            {
                connnString.Open();
                command.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Please Check Server and Database name. Server and Database name are incorrect .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                if (connnString.State == ConnectionState.Open)
                {
                    connnString.Close();
                }
            }
            return true;

        }

        public bool isDatabaseExist()
        {
            /*
             * This function checks if the database exist
             */

            string sqlDBQuery;
            bool result = false;
            try
            {
                connnString = new SqlConnection(dbConnString);

                sqlDBQuery = string.Format("SELECT database_id FROM sys.databases WHERE Name = '{0}'", databaseName);

                using (connnString)
                {
                    using (SqlCommand sqlCmd = new SqlCommand(sqlDBQuery, connnString))
                    {
                        connnString.Open();

                        object resultObj = sqlCmd.ExecuteScalar();

                        int databaseID = 0;

                        if (resultObj != null)
                        {
                            int.TryParse(resultObj.ToString(), out databaseID);
                        }

                        connnString.Close();

                        result = (databaseID > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }

        public bool isTableExist()
        {
            /*
             * This function checks if the table is in the database.                                  
             */
            bool result;
            connnString = new SqlConnection(dbConnString);

            try
            {

                connnString.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connnString;

                cmd.CommandText = "select case when exists((select* from INFORMATION_SCHEMA.TABLES where TABLE_NAME = '" + tableName + "')) then 1 else 0 end";
                cmd.ExecuteNonQuery();

                object resultObj = cmd.ExecuteScalar();
                int databaseID = 0;
                if (resultObj != null)
                    int.TryParse(resultObj.ToString(), out databaseID);


                connnString.Close();

                result = (databaseID > 0);

                cmd.Dispose();
                connnString.Close();
                return result;
            }
            catch
            {
                return false;
            }
            
        }

        public bool createTable()
        {
            try
            {
                connnString = new SqlConnection(tableConnString);

                /* creating a new table as tableName.dbo*/
                connnString.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connnString;
                cmd.CommandText = "CREATE TABLE [dbo].[" + tableName + "](" +
                    "[Name Surname] [varchar] (50)," +
                    "[BMI] [varchar](50) NULL," +
                    "[Date] [datetime] DEFAULT getdate()" +
                    ");";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connnString.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable fetchAllWithName(string name)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand com = new SqlCommand();
            DataSet ds = new DataSet();


            connnString = new SqlConnection(tableConnString);


            da = new SqlDataAdapter("Select BMI, date  from " + tableName + " where BMI IS NOT NULL AND [Name Surname] = '"+name+"'", connnString);       //It pulls the table to datagridview.
            ds = new DataSet();
            connnString.Open();
            da.Fill(ds, tableName);
            connnString.Close();
            da.Dispose();

            return ds.Tables[tableName];

        }

        public void addRow(string name, string BMI)
        {

            connnString = new SqlConnection(tableConnString);


            connnString.Open();

            SqlCommand cmd = new SqlCommand("Insert Into " + tableName + "([Name Surname], BMI) Values('"+name+ "','" + BMI + "')", connnString); //Saves the BMI measurement and name to the database.
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connnString.Close();
        }

        public int LastMeasureDate(string name) // Returns how many days have passed since the last measurement date.
        {
            int LastMeasure = 0;
            connnString = new SqlConnection(tableConnString);
            connnString.Open();
            SqlCommand cmd = new SqlCommand("select DateDIFF(day, date, GETDATE()) from " + tableName + " where date = (Select MAX(date) from " + tableName + " where [Name Surname] = '"+name+"')", connnString);
            cmd.ExecuteNonQuery();
            LastMeasure = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            connnString.Close();
            return LastMeasure;
        }

        public double LastMeasuredBMI(string name) //Returns the last measured BMI.
        {
            double LastMeasure = 0;
            connnString = new SqlConnection(tableConnString);
            connnString.Open();

            SqlCommand cmd = new SqlCommand("select BMI from " + tableName + " where date = (Select MAX(date) from "+ tableName +" where [Name Surname] = '"+name+"')", connnString);
            cmd.ExecuteNonQuery();
            LastMeasure = Convert.ToDouble(cmd.ExecuteScalar());
            cmd.Dispose();
            connnString.Close();
            return LastMeasure;
        }

    }
}
