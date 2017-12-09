#include <DHT.h>
#include <WiFi.h>
#include <SPI.h>

int analogPin = 23;
int raw = 0;
float Vin = 3.3F;
int empty = 28;
int ctvrt = 27;
int pul = 26;
int trictvrt = 25;
int full = 24;
float Vout = 0;
float R1 = 1000;
float R2 = 0;
float buffer = 0;

char ssid[] = "hackathon";
char pass[] = "att4hack";
IPAddress hostIp(184, 106, 153, 149);
String writeAPIKey = "AG9NU2DHLD00YR80";
const int updateThingSpeakInterval = 5 * 1000;
long lastConnectionTime = 0;
boolean lastConnected = false;
int failedCounter = 0;
WiFiClient client;

float Resistance = 0;
float Humidity = 0;
float Temperature = 0;
float Naplneni = 0;
int CHANNEL_ID = 381221;
String READ_KEY = "6123BHFJB7WJY5HC";

#define LED RED_LED
#define DHTPIN 38
#define DHTTYPE DHT22

DHT dht(DHTPIN, DHTTYPE);

void setup() {
  Serial.begin(115200);
  WiFi.begin(ssid, pass);
  dht.begin();

  pinMode(LED, OUTPUT);
  pinMode(38, INPUT);
  pinMode(GREEN_LED, OUTPUT);
  pinMode(17, OUTPUT);
  pinMode(35, OUTPUT);
  pinMode(36, OUTPUT);
  pinMode(37, OUTPUT);
}

void loop() {
  // Porovnávačka
  raw = analogRead(analogPin);
  if (raw)
  {
    buffer = raw * Vin;
    Vout = (buffer) / 1024.0;
    buffer = (Vin / Vout) - 1;
    R2 = R1 * buffer;

    Resistance = R2;
  }

  // Humidity
  Temperature = dht.readTemperature();
  Humidity = dht.readHumidity();

  if (isnan(Temperature) || isnan(Humidity)) {
    Temperature = 0;
    Humidity = 0;
  }

  // Naplneni
  if (digitalRead(full)  == HIGH)
  {
    Naplneni = 100;
  }
  else if (digitalRead(trictvrt) == HIGH)
  {
    Naplneni = 75;
  }
  else if (digitalRead(pul) == HIGH)
  {
    Naplneni = 50;
  }
  else if (digitalRead(ctvrt) == HIGH)
  {
    Naplneni = 25;
  }
  else if (digitalRead(empty) == HIGH)
  {
    Naplneni = 0;
  }

  // WiFi
  digitalWrite(LED, HIGH);
  digitalWrite(38, HIGH);

  if (client.available())
  {
    char c = client.read();
    Serial.print(c);
  }
  // Disconnect from ThingSpeak
  if (!client.connected() && lastConnected)
  {
    Serial.println("...disconnected");
    Serial.println();

    client.stop();
  }

  // Update ThingSpeak
  if (!client.connected() && (millis() - lastConnectionTime > updateThingSpeakInterval))
  {
    updateThingSpeak("field1=" + String(Resistance) + "&field2=" + String(Temperature) + "&field3=" + String(Humidity) + "&field4=" + String(Naplneni));
  }

  // Check if WiFi needs to be restarted
  if (failedCounter > 3 ) {
    failedCounter = 0;
    startWiFi();
  }

  lastConnected = client.connected();
}

void updateThingSpeak(String tsData)
{
  Serial.println("Updating ThingSpeak");

  if (client.connect(hostIp, 80)) {
    Serial.println("Connected to ThingSpeak!");
    Serial.println();

    // Odesílání dat
    client.print("POST /update HTTP/1.1\n");
    client.print("Host: api.thingspeak.com\n");
    client.print("Connection: close\n");
    client.print("X-THINGSPEAKAPIKEY: " + writeAPIKey + "\n");
    client.print("Content-Type: application/x-www-form-urlencoded\n");
    client.print("Content-Length: ");
    client.print(tsData.length());
    client.print("\n\n");
    client.print(tsData);

    client.print("GET /channels/");
    client.print(CHANNEL_ID);
    client.print("/field/5/last.txt?key=");
    client.print(READ_KEY);
    client.print(" HTTP/1.1");
    client.print("Host: api.thingspeak.com\n");
    client.print("Connection: close\n");

    int val = 1;

    while (client.available() == 0);  // wait till something comes in; you may want to add a timeout here

    unsigned long lastRead = millis();  // keeps track of last time a byte was read
    while (millis() - lastRead < 2000) {  // while 2 secs havent passed since a byte was read
      while (client.available()) {
        Serial.print(client.read());
        lastRead = millis();   // update last time something was read
      }
    }

    digitalWrite(17, LOW);
    digitalWrite(35, LOW);
    digitalWrite(36, LOW);
    digitalWrite(37, LOW);

    if (val == 0) {

    } else if (val == 1) {
      digitalWrite(17, HIGH);
    } else if (val == 2) {
      digitalWrite(35, HIGH);
    } else if (val == 3) {
      digitalWrite(36, HIGH);
    } else if (val == 4) {
      digitalWrite(37, HIGH);
    }

    Serial.println("Updated!");
    failedCounter = 0;
  } else {
    failedCounter++;
    client.stop();

    Serial.println("Connection to ThingSpeak Failed (" + String(failedCounter, DEC) + ")");
    Serial.println();
  }

  lastConnectionTime = millis();
}

void startWiFi()
{
  WiFi.disconnect();
  client.stop();

  Serial.print("Connecting LaunchPad to SSID:");
  Serial.print(ssid);
  Serial.println();

  // Connect to network and obtain an IP address using DHCP
  if (WiFi.begin(ssid, pass) == 0) {
    Serial.println("Connected to WiFi!");
    // Wait 5 seconds to get a valid IP address
    delay(5000);
    printWifiStatus();
    Serial.println();
  } else {
    Serial.println("LaunchPad connected to network using DHCP");
    Serial.println();
  }

  delay(1000);
}

void printWifiStatus() {
  // print the SSID of the network you're attached to:
  Serial.print("SSID: ");
  Serial.println(WiFi.SSID());

  // print your WiFi shield's IP address:
  IPAddress ip = WiFi.localIP();
  Serial.print("IP Address: ");
  Serial.println(ip);
}
