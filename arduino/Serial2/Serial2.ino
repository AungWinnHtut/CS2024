// C++ code
//
void setup()
{
  pinMode(2, OUTPUT);
  Serial.begin(9600); //initialized
}

void loop()
{
 	if(Serial.available()>0)
    {
      byte cmd = Serial.read();
      if(cmd=='1')
      {
        digitalWrite(2,HIGH);
        Serial.println("Motor is running");
      }
      else if(cmd=='0')
      {
        digitalWrite(2,LOW);
        Serial.println("Motor is stopping");
      }
      else{
        Serial.println("Wrong command! enter only 1 and 0");
      }
    }
}