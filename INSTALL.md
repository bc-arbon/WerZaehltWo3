# Installation
![Aufbau](https://raw.githubusercontent.com/dahafner/WerZaehltWo3/master/doc/setup.jpg)

## Prerequisites
- .NET Framework 4.8
- 2 Bildschirme (z.B. Monitor und Beamer)

## Schnellstart
1. Anzahl Felder festlegen
2. Spieler erfassen im Spielereditor
3. Displayfenster auf den 2. Monitor schieben
4. Spieler auf den Feldern eintragen
5. Grüner Haken klicken, um Anzeige zu aktualisieren

## Tipps
### Spieler aus Tournamentsoftware importieren
Die Import-Funktion ist im Spielereditor zu finden.
Zum Importieren aller gemeldeten Spieler muss die entsprechende *.ts-Datei ausgewählt werden.

### Verwalten der Spielerbestände
Im Programmverzeichnis befindet sich die Datei playerboard.json. Falls man z.B. am Morgen und am Nachmittag verschiedene Spieler in der Halle, kann man vorgängig verschiedene Versionen der playerboard.json 
vorbereiten und je nach Bedarf im Programmverzeichnis ablegen.

### Doppelpaarungen
Die beiden Namen bei Doppel und Mixed können mit einem " / " getrennt werden. Auf dem Display wird dies dann als Zeilenumbruch angezeigt.
![Doppelpaarungen](https://raw.githubusercontent.com/dahafner/WerZaehltWo3/master/doc/slash.png)