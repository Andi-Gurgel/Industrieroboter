using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sinn und Zweck der Klasse Eingabe:
//- Überprüfung: Ist die eingabe eine Zahl?
//- Soll das Hauptprogramm besser lesbar machen, statt 8x try catch zu verwenden

namespace Industrieroboter
{
    internal class Eingabe
    {
        public static int Zahl(string text)
        {
            try
            {
                return int.Parse(text);
            }
            catch
            {
                Console.WriteLine("Ungültige Eingabe.");
                return -1;
            }
        }

    }
}
