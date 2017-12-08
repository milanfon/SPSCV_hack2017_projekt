#include <DHT.h>

int analogPin = 0;
int raw= 0;
int Vin= 5;
float Vout= 0;
float R1= 1000;
float R2= 0;
float buffer= 0;

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
    
    Serial.print("Vout: ");
    Serial.print(Vout);
    Serial.println();
    
    Serial.print("R2: ");
    Serial.print(R2);
    Serial.println();
   }
  
  // Humidity
  float temp = dht.readTemperature();
  float humid = dht.readHumidity();
  if(isnan(temp) || isnan(humid)) {
    Serial.print("chyba při čtení");
  }
    else{
  Serial.print("Temperature = ");
  Serial.println(temp);
  Serial.print("Humidity = ");
  Serial.println(humid);
  }
  delay(1000);
}
