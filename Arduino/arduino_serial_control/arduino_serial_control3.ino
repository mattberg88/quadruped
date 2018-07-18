#include <Servo.h>

String readString;
int FLForearm = 50;
int FRForearm = 120;
int RLForearm = 120;
int RRForearm = 90;
int FLBicep = 90;
int FRBicep = 90;
int RLBicep = 90;
int RRBicep = 70;
int FLShoulder = 120;
int FRShoulder = 20;
int RLShoulder = 120;
int RRShoulder = 20;

Servo fl_forearm;
Servo fr_forearm;
Servo rl_forearm;
Servo rr_forearm;
Servo fl_bicep;
Servo fr_bicep;
Servo rl_bicep;
Servo rr_bicep;
Servo fl_shoulder;
Servo fr_shoulder;
Servo rl_shoulder;
Servo rr_shoulder;

void setup() {

  Serial.begin(38400);

  fl_forearm.attach(3);
  fr_forearm.attach(6);
  rl_forearm.attach(4);
  rr_forearm.attach(13);
  fl_bicep.attach(8);
  rl_bicep.attach(5);
  fr_bicep.attach(2);
  rr_bicep.attach(7);
  fl_shoulder.attach(10);
  fr_shoulder.attach(9);
  rl_shoulder.attach(11);
  rr_shoulder.attach(12);

  fl_forearm.write(FLForearm);
  fr_forearm.write(FRForearm);
  rl_forearm.write(RLForearm);
  rr_forearm.write(RRForearm);
  fl_bicep.write(FLBicep);
  fr_bicep.write(FRBicep);
  rl_bicep.write(RLBicep);
  rr_bicep.write(RRBicep);
  fl_shoulder.write(FLShoulder);
  fr_shoulder.write(FRShoulder);
  rl_shoulder.write(RLShoulder);
  rr_shoulder.write(RRShoulder);


  Serial.println("servo-test");

}

void loop() {

  while (Serial.available()) {
    char c = Serial.read();
    readString += c;
    delay(2);

    // if(readString.length() > 36){
    //   readString = "";
    // }

  }

  if (readString.length() > 0) {

    Serial.println(readString);

     fl_forearm.write((readString.substring(0,3))toInt() + FLForearm);
     fr_forearm.write((readString.substring(3,6))toInt() + FRForearm);
     rl_forearm.write((readString.substring(6,9))toInt() + RLForearm);
     rr_forearm.write((readString.substring(9,12))toInt() + RRForearm);

     fl_bicep.write((readString.substring(12,15)).toInt() + FLBicep);
     fr_bicep.write((readString.substring(15,18)).toInt() + FRBicep);
     rl_bicep.write((readString.substring(18,21)).toInt() + RLBicep);
     rr_bicep.write((readString.substring(21,24)).toInt() + RRBicep);

     fl_shoulder.write((readString.substring(24,27)).toInt() + FLShoulder);
     fr_shoulder.write((readString.substring(27,30)).toInt() + FRShoulder);
     rl_shoulder.write((readString.substring(30,33)).toInt() + RLShoulder);
     rr_shoulder.write((readString.substring(33,36)).toInt() + RRShoulder);

  }
    readString="";

}
