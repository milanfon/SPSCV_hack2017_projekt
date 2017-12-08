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

void ohmovka()
{ 
  
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
    
    Serial.print("R2: ");
    Serial.print(R2);
    Serial.println();
   }
  
  if(digitalRead(full)  == HIGH)
  {Serial.println("Plno");}
  else if (digitalRead(trictvrt) == HIGH)
  {Serial.println("víc jak 3/4");}
   else if (digitalRead(pul) == HIGH)
  {Serial.println("víc jak půl");}
   else if (digitalRead(ctvrt) == HIGH)
  {Serial.println("Víc jak 1/4");}
   else if (digitalRead(empty) == HIGH)
  {Serial.println("Víc jak 0");}
  else {Serial.println("prázdná");}
  
 

  
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

  
  delay(3000);
}
