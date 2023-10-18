#include <Wiichuck.h>
#include <Wire.h>

Wiichuck chuck;

void setup(){
  
  chuck.init(0,0);
  chuck.calibrate();

  Serial.begin(9600);
  
  
  }

  void loop(){

    if(chuck.poll()){
      Serial.print(" x: ");
      Serial.print(chuck.accelX());
      
      Serial.print(" y: ");
      Serial.print(chuck.accelY());  

      Serial.print(" z: ");
      Serial.println(chuck.accelZ());      
      }
    delay(100);
    
    }
/*
 
//Void motor de vibracion (Pins dañados en placa arduino)

void loop()
{
  digitalWrite(8,HIGH);
delay(300);
digitalWrite(8,LOW);
delay(300);

digitalWrite(9,HIGH);
delay(2000);
digitalWrite(9,LOW);
delay(100);
  }
*/
