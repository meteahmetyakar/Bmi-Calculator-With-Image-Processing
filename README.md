# BMI CALCULATOR

## Overview

The software is an extremely primitive prototype written to work on image processing and AI. The aim of the software is to calculate the bmi from the person's photo and compare it with the previous measurements, if any, and make recommendations. There is no height, weight or any other entry in the software. Bmi calculation and recognition the person is done with the person's photo.
The software approximately 70% correct results.

* In the project, i used LBPG Algorithm and I developed in windows forms with C#

# 

## Usage and installation

### Ip Camera Input Screen

We enter the ip of the ip camera there may be changes in the code according to the ip camera software you use, you can edit it. I used my own phone as a ip camera.
<br></br>
<p align="center">
  <img src="https://github.com/meteahmetyakar/Bmi-Calculator-With-Image-Processing/blob/main/images/ip-camera-input.png" />
</p>
<br></br>

<p align="center">
  <img src="https://github.com/meteahmetyakar/Bmi-Calculator-With-Image-Processing/blob/main/images/ip-camera-input-code.png" />
</p> 
<h3 align="center">ip camera part in CameraScreen.cs</h3>

# 

### Face Recognition Screen

* In this screen software is using webcam of computer because here the webcam is more useful than ip camera, but it can be easily converted to ip camera.
* İf dot is green, this mean face detected and it can recognize

<p align="center">
  <img src="https://github.com/meteahmetyakar/Bmi-Calculator-With-Image-Processing/blob/main/images/face-detection.gif" />
</p> 

# 

### Camera Screen

* Here the software uses the phone camera as an ip camera, I did not use a webcam because the phone camera can take portraits. It is very difficult to take portraits on webcam
* For healthy results, the camera should be kept parallel to the person and the person should be centered.

<p align="center">
  <img src="https://github.com/meteahmetyakar/Bmi-Calculator-With-Image-Processing/blob/main/images/camera-screen.png" />
</p> 

# 

### Result Screen

* Here old results are drawn from the database, compared with the new result and recommendations are given to the person

<p align="center">
  <img src="https://github.com/meteahmetyakar/Bmi-Calculator-With-Image-Processing/blob/main/images/result-screen.png" />
</p> 

<br></br>
<br></br>

* When BMI calculating the background of the captured photo is deleted and I use the remove.bg site's api to do this.
* This site gives you 5 free attempts, that's why api-key must be change regularly.

<p align="center">
  <img src="https://github.com/meteahmetyakar/Bmi-Calculator-With-Image-Processing/blob/main/images/remove-bg-part.png" />
</p>
<h3 align="center">You must write your api-key in the second part on line 65</h3>


# 

### Database Part

* The software creates the database itself, changing the following three variables in the database.cs class will be sufficient for the database connection.
<br></br>
<p align="center">
  <img src="https://github.com/meteahmetyakar/Bmi-Calculator-With-Image-Processing/blob/main/images/database-information.png" />
</p>
<h4 align="center">You just need to change the server name for the software to work. No need to manually create databases or tables.</h4>

# 

### I used [this](https://github.com/meteahmetyakar/Bmi-Calculator-With-Image-Processing/blob/main/Calculation-of-BMI-using-image-processing-techniques.pdf) article to create the algorithm of the body mass index calculation from the photo.
