# Wer zählt wo
![Aufbau](doc/setup.jpg)

## Prerequisites
- .NET Framework 4.8
- 2 Bildschirme (z.B. Monitor und Beamer)

## Schnellstart
1. Werzaehltwo3.exe starten
2. Anzahl Felder festlegen
3. Spieler erfassen im Spielereditor
4. Displayfenster auf den 2. Monitor schieben
5. Spieler auf den Feldern eintragen
6. Grüner Haken klicken, um Anzeige zu aktualisieren

## Tipps
### Spieler aus Tournamentsoftware importieren
Die Import-Funktion ist im Spielereditor zu finden.
Zum Importieren aller gemeldeten Spieler muss die entsprechende *.ts-Datei ausgewählt werden.

### Verwalten der Spielerbestände
Im Programmverzeichnis befindet sich die Datei playerboard.json. Falls man z.B. am Morgen und am Nachmittag verschiedene Spieler in der Halle hat kann man vorgängig verschiedene Versionen der playerboard.json 
vorbereiten und je nach Bedarf im Programmverzeichnis ablegen.

### Doppelpaarungen
Die beiden Namen bei Doppel und Mixed können mit einem " / " getrennt werden. Auf dem Display wird dies dann als Zeilenumbruch angezeigt.

![Doppelpaarungen](doc/slash.png)

# Tournamentsoftware Data Server

## Prerequisites
- .NET Framework 4.8
- [RabbitMQ Server](https://www.rabbitmq.com/)

## Konfiguration
1. TsDataServer.exe starten
2. Pfad zur Tournamentsoftware-Datenbank eintragen
3. RabbitMQ Server und Credentials eintragen
4. Updateintervall festlegen (10 Sekunden empfohlen)
5. Start

## Hinweise

### Message TTL
