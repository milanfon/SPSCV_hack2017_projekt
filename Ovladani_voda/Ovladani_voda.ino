#include <WiFi.h>

char ssid[] = "Milanfon Mobile Network";
char pass[] = "justforme";
byte mac[6];

#define LED RED_LED

void setup() {
  Serial.begin(9600);
  WiFi.begin(ssid, pass);
  pinMode(LED, OUTPUT);

  WiFi.macAddress(mac);

  Serial.print("MAC: ");
  Serial.print(mac[5],HEX);
  Serial.print(":");
  Serial.print(mac[4],HEX);
  Serial.print(":");
  Serial.print(mac[3],HEX);
  Serial.print(":");
  Serial.print(mac[2],HEX);
  Serial.print(":");
  Serial.print(mac[1],HEX);
  Serial.print(":");
  Serial.println(mac[0],HEX);
}

void loop() {
  // put your main code here, to run repeatedly: 
  digitalWrite(LED,HIGH);
}
