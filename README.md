<h3>Setup:</h3>
<ul>
<li> Upload arduino code in `Arduino/arduino_serial_control/arduino_serial_control.ino` and open serial port to check if it says "servo-test". 
<li> Close serial port window, then open Unity, go to open project.
<li>  Open `Unity` project folder and open scene `test.unity` , press play to initialize engine and activate serial port communication.
<li>  Turn Cylinder objects on the positive Y axis to move servos connected to arduino pins 9 and 10.
<li>  C# code for the Unity scene is in the `Unity/Assets/` folder, called `SerialPortHandler.cs`.
</ul>
<h3>Log:</h3>

<ul>  
  <li>7/9/2018 : This is an early and very rough work-in-progress project to control servo motors on a arduino-controlled quadruped walker robot through the Unity game engine. This way, motor rotations can be mapped to a 3D proxy model animated in maya, hopefully making the process of coding a movement cycle much easier. Eventually I want to make it bluetooth controlled and battery powered, with many programmed animations triggered by key/controller commands through Unity.
</ul>
