String readString;
#include <Servo.h> 
Servo servo1;  // create servo object to control a servo 
Servo servo2;
Servo servo3;
Servo servo4;
void setup() {
  Serial.begin(9600);
  servo1.attach(9);
  servo2.attach(10);
  servo3.attach(11);
  servo4.attach(12);
  Serial.println("servo-test"); // so I can keep track of what is loaded
}

void loop() {

  while (Serial.available()) {
    char c = Serial.read();  //gets one byte from serial buffer
    readString += c; //makes the String readString
    delay(2);  //slow looping to allow buffer to fill with next character
  }

  if (readString.length() >0) {
    Serial.println(readString);  //so you can see the captured String 
    int n = readString.toInt();  //convert readString into a number
    Serial.println(n); //so you can see the integer
    if(n>1000)
    {
      servo2.write(n-1000);
      servo4.write(n-1000);
    }
    if(n<1000)
    {
      servo1.write(n);
      servo3.write(n);
    
    }
    readString="";
  } 
}

