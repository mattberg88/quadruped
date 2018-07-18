#include <Servo.h> 

String readString;
int n;
int FLForearm;
int FRForearm;
int RLForearm;
int RRForearm;
int FLBicep;
int FRBicep;
int RLBicep;
int RRBicep;
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
  

  fl_forearm.write(50);
  fr_forearm.write(120);
  rl_forearm.write(120);
  rr_forearm.write(90);
  fl_bicep.write(90);
  fr_bicep.write(90);
  rl_bicep.write(90);
  rr_bicep.write(70);
  fl_shoulder.write(120);
  fr_shoulder.write(20);
  rl_shoulder.write(120);
  rr_shoulder.write(20);
 ;
  
  Serial.println("servo-test"); 
 
}

void loop() {

  while (Serial.available()) {
    char c = Serial.read();  
    readString += c; 
    delay(2);  
  }
  
  if (readString.length() > 0) {
    
    Serial.println(readString);  
//    n = readString.ToInt();
   
 //       fl_forearm.write(readString.toInt());
//        fr_forearm.write(readString.toInt());
//        rl_forearm.write(readString.toInt());
//        rr_forearm.write(readString.toInt());
    FLForearm = (readString.substring(0,3)).toInt();
    FRForearm = (readString.substring(3,6)).toInt();
    RLForearm = (readString.substring(6,9)).toInt();
    RRForearm = (readString.substring(9,12)).toInt();

    FRBicep = (readString.substring(12,15)).toInt();
//    FLBicep = (readString.substring(15,18)).toInt();
//    rl_bicep.write((readString.substring(18,21)).toInt());
//    rr_bicep.write((readString.substring(21,24)).toInt());

//    fl_shoulder.write((readString.substring(24,27)).toInt());
//    fr_shoulder.write((readString.substring(27,30)).toInt());
//    rl_shoulder.write((readString.substring(30,33)).toInt());
//    rr_shoulder.write((readString.substring(33,36)).toInt());
      fl_forearm.write(FLForearm);
      fr_forearm.write(FRForearm);
      rl_forearm.write(RLForearm);
      rr_forearm.write(RRForearm);
      fr_bicep.write(FRBicep);
 //     fl_bicep.write(FLBicep);
  }
  if (readString.length() > 15) {
    
    Serial.println();  
  }
    readString="";
    
} 



