using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrieroboter
{
    public class Industrieroboter
    {
        public int MaxAnzWerkzeuge { get; }
        private Werkzeug[] werkzeugkasten;
        //Konstruktor, der die maximale Anzahl an Werkzeugen festlegt und den Werkzeugkasten initialisiert
        public Industrieroboter(int maxAnzWerkzeuge)
        {
            MaxAnzWerkzeuge = maxAnzWerkzeuge;
            werkzeugkasten = new Werkzeug[maxAnzWerkzeuge];
        }

        //Gibt die Werkzeuge auf dem angegebenen Platz zurück, oder null, wenn der Platz leer ist oder nicht existiert
        public Werkzeug GetWerkzeug(int platz)
        {
            if (platz < 0 || platz >= MaxAnzWerkzeuge)
                return null;

            return werkzeugkasten[platz];
        }

        public bool WerkzeugHinzufuegen(int platz, Werkzeug w)
        {
            if (platz < 0 || platz >= MaxAnzWerkzeuge)
            {
                Console.WriteLine($"Hinzufügen nicht möglich, da Platz {platz} nicht existiert.");
                return false; 
            }

            if (werkzeugkasten[platz] != null)
            {
                Console.WriteLine($"Hinzufügen nicht möglich, da Platz {platz} belegt ist.");
                return false;
            }

            werkzeugkasten[platz] = w;
            Console.Write("Hinzugefügtes Werkzeug auf Platz " + platz + ": ");
            w.Ausgeben();
            return true;
        }
        
        public bool WerkzeugEntfernen(int platz)
        {
            if (platz < 0 || platz >= MaxAnzWerkzeuge)
            {
                Console.WriteLine($"Entfernen nicht möglich, da Platz {platz} nicht existiert.");
                return false;
            }

            if (werkzeugkasten[platz] == null)
            {
                Console.WriteLine($"Entfernen nicht möglich, da Platz {platz} nicht belegt ist.");
                return false;
            }

            Console.Write("Entferntes Werkzeug auf Platz " + platz + ": ");
            werkzeugkasten[platz].Ausgeben();

            werkzeugkasten[platz] = null;
            return true;
        }

        public void WerkzeugkastenAnzeigen()
        {
            for (int i = 0; i < MaxAnzWerkzeuge; i++)
            {
                if (werkzeugkasten[i] == null)
                    Console.WriteLine($"Platz {i}: leer");
                else
                {
                    Console.Write($"Platz {i}: ");
                    werkzeugkasten[i].Ausgeben();
                }
            }
        }
    }

}
