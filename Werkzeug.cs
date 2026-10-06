using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrieroboter
{
    public abstract class Werkzeug
    {

        //schreibt automatisch ein privates feld im Hintergrund, siehe _verschleiss bzw Veschleiss, ausgeschriebene Variante mit get und set
        public string Art { get; set; }
        private int _verschleiss;

        public int Verschleiss
        {
            get { return _verschleiss; }
            set { _verschleiss = value; }
        }


        //  Konstruktor 
        public Werkzeug(string art, int verschleiss = 0)
        {
            Art = art;
            Verschleiss = verschleiss;
        }

        //methode abstract: Pflichtvorgabe für alle Unterklassen, die diese Methode implementieren müssen
        //                  Unterklassen müssen die Methode überschreiben (override)
        public abstract void Ausgeben();
        
    }


    public class Bohrer : Werkzeug
    {
        public int Groesse { get; set; }

        public Bohrer(int groesse, int verschleiss = 0) : base("Bohrer", verschleiss)
        {
            Groesse = groesse;
        }

        public override void Ausgeben()
        {
            Console.WriteLine($"Bohrer mit Groesse {Groesse} (Verschleiss {Verschleiss} %).");
        }
    }


    public class Greifer : Werkzeug
    {
        public Greifer() : base("Greifer") { }

        public override void Ausgeben()
        {
            Console.WriteLine($"Greifer (Verschleiss {Verschleiss} %).");
        }
    }


    public class Schweisser : Werkzeug
    {
        public Schweisser() : base("Schweisser") { }

        public override void Ausgeben()
        {
            Console.WriteLine($"Schweisser (Verschleiss {Verschleiss} %).");
        }
    }


}
