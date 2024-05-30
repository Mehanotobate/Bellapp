const int bellPin = 11;
const int baudRate = 9600;
void setup() {
  // Initialize serial communication at a specific baud rate (e.g., 9600)
  Serial.begin(baudRate);
  pinMode(bellPin, OUTPUT);
}

void loop() {
  // Check if data is available to read from the serial port
  if (Serial.available() > 0) {
    String incomingData = Serial.readStringUntil('\n');

    // Process the received character
    switch (incomingData[0]) {
      case 'R':
        switch (incomingData[1]) {
          case '1':
            digitalWrite(bellPin, HIGH);
            delay(1000);
            digitalWrite(bellPin, LOW);
            break;
          case '2':
            digitalWrite(bellPin, HIGH);
            delay(10000);
            digitalWrite(bellPin, LOW);
            break;
          case '3':
            digitalWrite(bellPin, HIGH);
            delay(2000);
            digitalWrite(bellPin, LOW);
            delay(1000);
            digitalWrite(bellPin, HIGH);
            delay(2000);
            digitalWrite(bellPin, LOW);
            delay(1000);
            digitalWrite(bellPin, HIGH);
            delay(2000);
            digitalWrite(bellPin, LOW);
            break;
          case '4':
            digitalWrite(bellPin, HIGH);
            delay(3000);
            digitalWrite(bellPin, LOW);
            delay(1000);
            digitalWrite(bellPin, HIGH);
            delay(3000);
            digitalWrite(bellPin, LOW);
            delay(1000);
            digitalWrite(bellPin, HIGH);
            delay(3000);
            digitalWrite(bellPin, LOW);
            break;
          case '5':
            digitalWrite(bellPin, HIGH);
            delay(4000);
            digitalWrite(bellPin, LOW);
            break;
        }    
        break;
    }
  }

  // Add other code or tasks here
}
