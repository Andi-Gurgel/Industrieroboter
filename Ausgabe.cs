using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sinn und Zweck der Klasse Ausgabe:
//- Alle Textausgabe aus dem Hauptprogramm rausziehen
//- Soll das Hauptprogramm besser lesbar machen und überschaubarer

namespace Industrieroboter
{
    internal class Ausgabe
    {

        public static void Hauptmenue()
        {
            Console.WriteLine("\n=== Werkzeugkasten-Verwaltung ===");
            Console.WriteLine("1. Werkzeug hinzufügen");
            Console.WriteLine("2. Werkzeug entfernen");
            Console.WriteLine("3. Werkzeugkasten anzeigen");
            Console.WriteLine("4. Werkzeug benutzen (Verschleiß erhöhen)");
            Console.WriteLine("5. Werkzeug warten (Verschleiß zurücksetzen)");
            Console.WriteLine("6. Beenden");
            Console.Write("Auswahl: ");
        }

        public static void WerkzeugartMenue()
        {
            
            Console.WriteLine("Werkzeugart:");
            Console.WriteLine("1. Bohrer");
            Console.WriteLine("2. Greifer");
            Console.WriteLine("3. Schweisser");
            Console.WriteLine("4. Zurück zum Hauptmenue");
        }

        public static void Clear()
        {
            Console.WriteLine("Weiter mit beliebiger Taste...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
