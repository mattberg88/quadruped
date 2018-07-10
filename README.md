*  Upload arduino code in `Arduino/arduino_serial_control/arduino_serial_control.ino` and open serial port to check if it says "servo-test". 
*  Close serial port window, then open Unity, go to open project.
*  Open `Unity` project folder and open scene `test.unity` , press play to initialize engine and activate serial port communication.
*  Turn Cylinder objects on the positive Y axis to move servos connected to arduino pins 9 and 10.
*  C# code for the Unity scene is in the `Unity/Assets/` folder, called `SerialPortHandler.cs`.
