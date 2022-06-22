# BMI CALCULATOR

## Overview

The program is an extremely primitive prototype written to work on image processing and AI. The aim of the program is to calculate the bmi from the person's photo and compare it with the previous measurements, if any, and make recommendations. There is no height, weight or any other entry in the program. Bmi calculation and recognition the person is done with the person's photo.
The program approximately 70% correct results.

# 

## Usage and installation

### Ip Camera Input Screen

We enter the ip of the ip camera there may be changes in the code according to the ip camera program you use, you can edit it. I used my own phone as a ip camera.
<br></br>
<p align="center">
  <img src="https://github.com/meteahmetyakar/Bmi-Calculator-With-Image-Processing-And-Face-Recognition/blob/main/images/ip-camera-input.png" />
</p>
<br></br>

<p align="center">
  <img src="https://github.com/meteahmetyakar/Bmi-Calculator-With-Image-Processing-And-Face-Recognition/blob/main/images/ip-camera-input-code.png" />
</p> 
<h3 align="center">ip camera part in CameraScreen.cs</h3>

# 

### Face Recognition Screen

* In this screen program is using webcam of computer because here the webcam is more useful than ip camera, but it can be easily converted to ip camera.
* İf dot is yellow, this mean face detected and it can train

<p align="center">
  <img src="https://github.com/meteahmetyakar/Bmi-Calculator-With-Image-Processing-And-Face-Recognition/blob/main/images/face-detection.gif" />
</p> 

# 

### Camera Screen

* Here the program uses the phone camera as an ip camera, I did not use a webcam because the phone camera can take portraits. It is very difficult to take portraits on webcam
* For healthy results, the camera should be kept parallel to the person and the person should be centered.

<p align="center">
  <img src="https://github.com/meteahmetyakar/Bmi-Calculator-With-Image-Processing-And-Face-Recognition/blob/main/images/camera-screen.png" />
</p> 

# 

### Result Screen

* Here old results are drawn from the database, compared with the new result and recommendations are given to the person

<p align="center">
  <img src="https://github.com/meteahmetyakar/Bmi-Calculator-With-Image-Processing-And-Face-Recognition/blob/main/images/result-screen.png" />
</p> 

