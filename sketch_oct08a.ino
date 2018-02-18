#include <Servo.h>  /* Servo kutuphanesi projeye dahil edildi */
Servo servoMotor;  /* servo motor nesnesi yaratildi */

#include <SoftwareSerial.h>
SoftwareSerial mySerial(10,11);

const int trigger_pin1 = 8;
const int echo_pin1 = 9;
const int trigger_pin2 = 6;
const int echo_pin2 = 7;
const int buzzer = 2;
const int mled = 4;
const int yled= 12;
const int sled = 5;
const int kled = 13 ;
int i = 0;
float sure;
long mesafe2;
long mesafe1;

void setup() {
  pinMode(kled,OUTPUT);
  pinMode(sled,OUTPUT);
  pinMode(yled,OUTPUT);
  pinMode(mled,OUTPUT);
  pinMode(buzzer,OUTPUT);
  pinMode(trigger_pin1, OUTPUT);
  pinMode(echo_pin1, INPUT);
  pinMode(trigger_pin2, OUTPUT);
  pinMode(echo_pin2, INPUT);
  servoMotor.attach(3);
  mySerial.begin(9600);
  Serial.begin(9600);



}

void loop() {

  digitalWrite(trigger_pin1 , HIGH);
  delayMicroseconds(1000);
  digitalWrite(trigger_pin1, LOW);
  sure = pulseIn(echo_pin1, HIGH);
  mesafe1 = (sure/2) / 29.1;

  digitalWrite(trigger_pin2 , HIGH);
  delayMicroseconds(1000);
  digitalWrite(trigger_pin2, LOW);
  sure = pulseIn(echo_pin2, HIGH);
  mesafe2 = (sure/2) / 29.1;
  
  if ( mesafe2 <= 10 && mesafe2 >= 0 )
  {
    digitalWrite(kled, HIGH);
    digitalWrite(buzzer, HIGH);
    delay(100);
    digitalWrite(kled, LOW);
    digitalWrite(buzzer, LOW);
    servoMotor.write(135);
  }



  else if ( mesafe2 <= 20 && mesafe2 >= 10 )
  {
    digitalWrite(sled, HIGH);
    digitalWrite(buzzer, HIGH);
    delay(200);
    digitalWrite(sled, LOW);
    digitalWrite(buzzer, LOW);
    servoMotor.write(110);
  }

   else if ( mesafe2 <= 30 && mesafe2 >= 20 )
  {
    digitalWrite(yled, HIGH);
    digitalWrite(buzzer, HIGH);
    delay(350);
    digitalWrite(yled, LOW);
    digitalWrite(buzzer, LOW);
    servoMotor.write(80);
  }

   else if (mesafe2 <= 40 && mesafe2 >= 30)
  {
    digitalWrite(mled, HIGH);
    delay(750);
    digitalWrite(mled, LOW);
    servoMotor.write(50);
   
  }

  
  if(mesafe1 < 300 && mesafe2 <300 && mesafe1 >4 && mesafe2 >4){
    mySerial.print(mesafe1); 
    mySerial.print(" ");
    mySerial.println(mesafe2);

    Serial.print(mesafe2); 
    Serial.print(" ");
    Serial.println(mesafe1);
  
  }


  delay(200);


}
