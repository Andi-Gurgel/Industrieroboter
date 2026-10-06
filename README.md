# Projektbeschreibung



Sie arbeiten als IT-Experte in der Planungsabteilung eines Herstellers von Fertigungsanlagen für die Industrie. Eine Fertigungsanlage besteht aus mehreren Fertigungsstationen, die wie folgt ausgestattet sind:

- Industrieroboter, der mit Werkzeugen bestückt werden kann.
- Rechner mit Netzwerkanbindung, der den Arbeitsablauf der Station steuert.
- Unterschiedliche Anzahl von Sensoren und Aktoren mit eigenen Netzwerkanbindungen.

## Aufgabe 1 (Basis)

Der Industrieroboter enthält einen Werkzeugkasten mit einer festen Anzahl von Plätzen. Die Plätze sind von 0 an durchnummeriert und können auch leer sein. An jedem Platz kann maximal ein Werkzeug (z. B. ein Greifer, Bohrer, Schweißer usw.) abgelegt werden. Werkzeuge können hinzugefügt oder entfernt werden.

Sie sollen einen Teil der Steuerungssoftware entsprechend dem folgenden Klassendiagramm programmieren.

![Diagramm](https://www.plantuml.com/plantuml/svg/VL9DZzem4BtxLupeXTN2AbmHIBkL-h7gaKFFJXWIQvqniiTB2Sr_xmHZ5AKIDyVpFjwR-3MmzXnRgyA7eQFskeNAwX3UcBqf8-DxvMXdEeHY10cDthkJeHeEsWQSahyxuXsVBG8vtsgh6hD7g8olBAOpjaS-GujjYJueTMN1E-rZ45lqhdIC7YuAO7cHY6og7bhzvuswt-W_EemrmXeCCMnXLS35emGYU-w5yJpLcJyDjwSRyQUXBXuYraZpezNShKLc0OHndRMVHBjqpevftuWFw6bCkiDwfNGfZhfYI5MoKggWFGjqY4IrV7_vbD9LOz48ChUG4iLcEvfijgkYkFR9OdFHMIUL1OoGrom2lEGGFJph66ei9UqGyjEPlUhpch-wnkVbrjvX2BTT3bvf-CXf0JTIjdtazSEZEIIpXxXTrPm6WuVG_zx7R3K3jrp2h7XvcRoE6UIZ2EH_-4i7HbBtoUQla5FZoMNAFRaTfLIlA65Q-my0)

### 1.1

Implementieren Sie die Klassen Industrieroboter, Werkzeug und Bohrer in einer *an Ihrer Schule gelehrten Programmiersprache*. Die Attribute und Methoden haben die im Folgenden angegebenen Bedeutungen.

#### Klasse Industrieroboter

| Attribut/Methode | Bedeutung |
|---|---|
| `maxAnzWerkzeuge` | Die maximale Anzahl der Werkzeuge, die der Roboter verwenden kann. |
| `Industrieroboter` | Initialisiert die Attribute falls erforderlich. |
| `werkzeugHinzufuegen` | Setzt das übergebene Werkzeug an den übergebenen Platz des Werkzeugkastens, wenn der Platz existiert und nicht bereits ein Werkzeug enthält. Der Rückgabewert ist bei erfolgreichem Hinzufügen TRUE, sonst FALSE.<br><br>Es wird ausgegeben, welches Werkzeug wo hinzugefügt wurde bzw. warum das Werkzeug nicht hinzugefügt werden konnte. |
| `werkzeugEntfernen` | Entfernt das Werkzeug vom übergebenen Platz des Werkzeugkastens, aber nur wenn der Platz existiert und bereits ein Werkzeug enthält. Der Rückgabewert ist bei erfolgreichem Entfernen TRUE, sonst FALSE.<br><br>Es wird ausgegeben, welches Werkzeug wo entfernt wurde bzw. warum das Werkzeug nicht entfernt werden konnte. |

#### Klasse Werkzeug

| Attribut/Methode | Bedeutung |
|---|---|
| `art` | Identifiziert die Art des Werkzeugs. |
| `verschleiss` | Eine Prozentangabe, die den Verschleiß des Werkzeugs angibt, wobei 0 bedeutet, dass das Werkzeug keinen Verschleiß aufweist, und 100, dass das Werkzeug komplett verschlissen ist. |
| `Werkzeug` | Initialisiert die Attribute mit übergebenen und/oder Standardwerten. |

#### Klasse Bohrer

| Attribut/Methode | Bedeutung |
|---|---|
| `groesse` | Größe des Bohrers in Millimetern. |
| `Bohrer` | Initialisiert die Attribute mit übergebenen und/oder Standardwerten. |
| `ausgeben` | Gibt den Text „Bohrer mit Groesse x (Verschleiss y %)." aus, wobei x und y durch die Werte des entsprechenden Bohrers ersetzt werden. |

### 1.2

Schreiben Sie ein Testprogramm für die nachfolgenden Testfälle.
Erzeugen Sie zunächst einen Industrieroboter und zwei Bohrer (Bohrer 1 und Bohrer 2, beide mit Größe 10 und Verschleiß 0).

| Testfall | Erwartete Ausgabe |
|---|---|
| Hinzufügen von Bohrer 1 an Platz 5 | Hinzugefügtes Werkzeug auf Platz 5: Bohrer mit Groesse 10 (Verschleiss 0 %). |
| Hinzufügen von Bohrer 2 an Platz 5 | Hinzufügen nicht möglich, da Platz 5 belegt ist. |
| Hinzufügen von Bohrer 2 an Platz 10 | Hinzufügen nicht möglich, da Platz 10 nicht existiert. |
| Hinzufügen von Bohrer 2 an Platz -1 | Hinzufügen nicht möglich, da Platz -1 nicht existiert. |
| Werkzeug entfernen von Platz 5 | Entferntes Werkzeug auf Platz 5: Bohrer mit Groesse 10 (Verschleiss 0 %). |
| Werkzeug entfernen von Platz 5 | Entfernen nicht möglich, da Platz 5 nicht belegt ist. |
| Werkzeug entfernen von Platz 10 | Entfernen nicht möglich, da Platz 10 nicht existiert. |
| Werkzeug entfernen von Platz -1 | Entfernen nicht möglich, da Platz -1 nicht existiert. |

---




## 2. Erweiterung: Konsolenanwendung mit Menüführung

Baue auf den bereits implementierten und getesteten Klassen (Industrieroboter, Werkzeug, Bohrer, Greifer, Schweisser) – dem **Domänenmodell** – eine Konsolenanwendung mit Menüführung zur Verwaltung eines Industrieroboters auf.

### Menüpunkte


=== Werkzeugkasten-Verwaltung ===
1. Werkzeug hinzufügen
2. Werkzeug entfernen
3. Werkzeugkasten anzeigen
4. Werkzeug benutzen (Verschleiß erhöhen)
5. Werkzeug warten (Verschleiß zurücksetzen)
6. Beenden


- **Hinzufügen/Entfernen/Beenden (1, 2, 6):** Beim Hinzufügen fragt das Programm zuerst nach dem Platz und anschließend – über ein Untermenü – nach der gewünschten Werkzeugart.
- **Anzeigen (3):** Iteriert über alle Plätze des Werkzeugkastens und gibt pro Platz entweder das Ergebnis von `ausgeben()` oder „Platz x: leer" aus.
- **Benutzen (4):** Der Nutzer wählt einen belegten Platz; der Verschleiß des dortigen Werkzeugs wird um einen wählbaren Wert erhöht, jedoch bei 100 gedeckelt.
- **Warten (5):** Setzt den Verschleiß eines gewählten Werkzeugs auf 0 zurück.
- **Statistik (optional, als Teil von 3 oder eigener Punkt):** Gibt den durchschnittlichen Verschleiß aller vorhandenen Werkzeuge, die Anzahl freier bzw. belegter Plätze sowie das am stärksten verschlissene Werkzeug aus.

## Optionale Refaktorierungen

- **Werkzeugarten verfeinern:** Ergänze in den konkreten Werkzeug-Klassen je ein eigenes, spezifisches Enum als zusätzliches Attribut. Das ererbte `art`-Attribut aus `Werkzeug` mit der Freitext-Bezeichnung bleibt dabei unverändert wie in der Basisaufgabe vorgegeben bestehen.

```csharp
public enum BohrerArt     { Spiralbohrer, Stufenbohrer, Kernbohrer, Gewindebohrer }
public enum GreiferArt    { Parallelgreifer, Vakuumgreifer, Magnetgreifer, Nadelgreifer }
public enum SchweisserArt { Punktschweissen, Schutzgasschweissen, WigSchweissen, Laserschweissen }
```

- **Fehlerbehandlung mit Exceptions:** Setze über gezielte Exceptions Leitplanken für das korrekte Hinzufügen- und Entfernen-Verhalten (z. B. ungültiger Platz, Platz bereits belegt).
  - Ein **ungültiger Platz** (außerhalb des gültigen Bereichs) löst eine Exception aus (z. B. `ArgumentOutOfRangeException`) – das ist ein Aufrufer-Fehler, kein normaler Geschäftsfall.
  - Ein **belegter bzw. leerer, aber existierender Platz** bleibt dagegen über den Rückgabewert (`bool`) abgesichert.

- **Echte Unit-Tests:** Aktuell wird zwar systematisch getestet, aber nur manuell per Sichtprüfung der Konsolenausgabe. Schreibe stattdessen automatisierte Unittests, die das Verhalten programmatisch absichern – über den erwarteten Rückgabewert bzw. die erwartetetn Ausnahmen



## Abgabebedingungen

- **Frist:** Freitag, 8:00 Uhr
- **Format:** Lösung als ZIP-Archiv einreichen
- **Namensschema:** `Nachname-Vorname-Industrieroboter.zip` (z. B. `Mueller-Florian-Industrieroboter.zip`)
- **Portfolio:** Das Projekt kann zusätzlich im persönlichen GitHub-Repository veröffentlicht werden.

### Begleitende Kurse (LinkedIn Learning)

- Vorbereitend: CodePad-Aufgabe zu abstrakten Klassen – https://www.linkedin.com/learning/c-sharp-programmierpraxis-interfaces-und-abstrakte-klassen/code-challenges/urn:li:la_assessmentV2:72784950
- Unterstützend: Kurs [OOP mit C#](https://www.linkedin.com/learning/objektorientierte-programmierung-oop-mit-c-sharp) (bis zum Video zur Polymorphie)


