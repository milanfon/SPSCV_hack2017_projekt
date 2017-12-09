#include <WiFi.h>
#include <SPI.h>

char ssid[] = "Milanfon Mobile Network";
char pass[] = "justforme";
IPAddress hostIp(184, 106, 153, 149);
String writeAPIKey = "AG9NU2DHLD00YR80";
const int updateThingSpeakInterval = 5 * 1000;
long lastConnectionTime = 0;
boolean lastConnected = false;
int failedCounter = 0;
WiFiClient client;

String Resistance = String(22);
String Temperature = String(69);
String Humidity = String(0.99f);
String Naplneni = String(0.25f);

#define LED RED_LED

void setup() {
  Serial.begin(115200);
  WiFi.begin(ssid, pass);
  pinMode(LED, OUTPUT);
}

void loop() {
  digitalWrite(LED, HIGH);

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
    updateThingSpeak("field1=" + Resistance + "&field2=" + Temperature + "&field3=" + Humidity + "&field4" + Naplneni);
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

    client.print("POST /update HTTP/1.1\n");
    client.print("Host: api.thingspeak.com\n");
    client.print("Connection: close\n");
    client.print("X-THINGSPEAKAPIKEY: " + writeAPIKey + "\n");
    client.print("Content-Type: application/x-www-form-urlencoded\n");
    client.print("Content-Length: ");
    client.print(tsData.length());
    client.print("\n\n");
    client.print(tsData);

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
