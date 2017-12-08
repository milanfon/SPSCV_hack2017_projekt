#include <dht.h>

int analogPin = 0;
int raw= 0;
int Vin= 5;
float Vout= 0;
float R1= 1000;
float R2= 0;
float buffer= 0;
dht DHT;

#define DHT11_PIN 2

void setup()
{
  Serial.begin(9600);
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
    
    Serial.print("Vout: ");
    Serial.print(Vout);
    Serial.println();
    
    Serial.print("R2: ");
    Serial.print(R2);
    Serial.println();
   }
  
  // Humidity
  int chk = DHT.read11(DHT11_PIN);
  Serial.print("Temperature = ");
  Serial.println(DHT.temperature);
  Serial.print("Humidity = ");
  Serial.println(DHT.humidity);
  delay(1000);
}
