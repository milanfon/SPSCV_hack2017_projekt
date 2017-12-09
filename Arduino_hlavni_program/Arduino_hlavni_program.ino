#include <DHT.h>

int analogPin = 0;
int raw= 0;
int Vin= 5;
int empty = 5;
int ctvrt = 6;
int pul = 7;
int trictvrt = 8;
int full = 9;
float Vout= 0;
float R1= 1000;
float R2= 0;
float buffer= 0;

unsigned int samplingTime = 280;
unsigned int deltaTime = 40;
unsigned int sleepTime = 9680;

#define typeDHT DHT22
#define DHT11_PIN 2
DHT dht(DHT11_PIN, typeDHT);

void setup()
{
  Serial.begin(9600);
  dht.begin();
}

void loop()
{
   // Ohmovka
    raw= analogRead(analogPin);
  if(raw) 
  {
    buffer= raw * Vin;
    Vout= (buffer)/1024.0;
    buffer= (Vin/Vout) -1;
    R2= R1 * buffer;
    
  //  Serial.print("Vout: ");
  //  Serial.print(Vout);
  //  Serial.println();
    
  //  Serial.print("R2: ");
    Serial.println(); 
    Serial.print(R2);
   }
   else {   
    Serial.println();}
  

//Tady nahradit Serial Výstupy za přenos dat přes Wifi do programu  
 

  
  // Humidity
  float temp = dht.readTemperature();
  float humid = dht.readHumidity();
  if(isnan(temp) || isnan(humid)) {
    Serial.print(",");
  }
    else{
  //Serial.print("Temperature = ");
  Serial.print(",");
  Serial.print(temp);
  //Serial.print("Humidity = ");
  Serial.print(",");
  Serial.print(humid);
  }
  if (digitalRead(full)  == HIGH)
  {Serial.print("100");}
   else if (digitalRead(trictvrt) == HIGH)
  {Serial.print(",75");}
   else if (digitalRead(pul) == HIGH)
  {Serial.print(",50");}
   else if (digitalRead(ctvrt) == HIGH)
  {Serial.print(",25");}
   else if (digitalRead(empty) == HIGH)
  {Serial.print(",25");}
   else {Serial.print(",0");}
  
  delay(3000);
}
