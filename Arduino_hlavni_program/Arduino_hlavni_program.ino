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
  String s = "";
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
    s += R2;
   }
  
  

//Tady nahradit Serial Výstupy za přenos dat přes Wifi do programu  
 

  
  // Humidity
  float temp = dht.readTemperature();
  float humid = dht.readHumidity();
  if(isnan(temp) || isnan(humid)) {
    s += ",0,0";
  }
    else{
  //Serial.print("Temperature = ");
  s += ",";
  s += temp;
  //Serial.print("Humidity = ");
  s += ",";
  s += humid;
  }
  if (digitalRead(full)  == HIGH)
  {s += ",100";}
   else if (digitalRead(trictvrt) == HIGH)
  {s += ",75";}
   else if (digitalRead(pul) == HIGH)
  {s += ",50";}
   else if (digitalRead(ctvrt) == HIGH)
  {s += ",25";}
   else if (digitalRead(empty) == HIGH)
  {s += ",25";}
   else {s += ",0";}

   Serial.println(s);
  
  delay(300);
}
