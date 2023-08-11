static int count = 0;
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  //Serial.println();
  Serial.println("\nPlease send commands (1,2,3,4) ");
}

void loop() {
 count++;
 if(Serial.available()>0)
 {
   byte cmd = Serial.read();
   if(cmd!=10)
   {
    switch(cmd){
      case 49: Serial.println("You send ONE"); break;
      case 50: Serial.println("You send TWO"); break;
      case 51: Serial.println("You send THREE"); break;
      case 52: Serial.println("You send FOUR"); break;
      default: Serial.println("You send Wrong Command! Pls send again (Only 1,2,3,4)"); break;
    }
   }
   
 }

}
