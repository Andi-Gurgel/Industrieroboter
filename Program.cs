namespace Industrieroboter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ruft den Konstruktor auf und setzt die maximale Anzahl der Werkzeuge auf 10
            Industrieroboter roboter = new Industrieroboter(10);
            int eingabe = -1;
            

            while (true)
            {
                Ausgabe.Hauptmenue();

                string text = Console.ReadLine();
                eingabe = Eingabe.Zahl(text);

                switch (eingabe)
                {
                    case 1:
                        WerkzeugHinzufuegenMenue(roboter);
                        break;
                    case 2:
                        WerkzeugEntfernenMenue(roboter);
                        break;
                    case 3:
                        roboter.WerkzeugkastenAnzeigen();
                        Ausgabe.Clear();
                        break;
                    case 4:
                        WerkzeugBenutzenMenue(roboter);
                        break;
                    case 5:
                        WerkzeugWartenMenue(roboter);
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Ungültige Eingabe.");
                        Console.ReadKey();
                        break;

                }
                
            }
            static void WerkzeugHinzufuegenMenue(Industrieroboter roboter)
            {
                int art = -1;
                int platz = -1;
                int groesse = 1;
                Werkzeug w = null;

                Console.Write("Platz(0-9): ");
                string text2 = Console.ReadLine();
                platz = Eingabe.Zahl(text2);

                while(true)
                {
                    Ausgabe.WerkzeugartMenue();

                    string text3 = Console.ReadLine();
                    art = Eingabe.Zahl(text3);

                    switch (art)
                    {
                        case 1:

                            Console.Write("Bohrergröße: ");
                            string text4 = Console.ReadLine();
                            groesse = Eingabe.Zahl(text4);
                            w = new Bohrer(groesse);
                            break;
                        case 2:
                            w = new Greifer();
                            break;
                        case 3:
                            w = new Schweisser();
                            break;
                        case 4:
                            return;

                        default:
                            Console.WriteLine("Ungültige Werkzeugart.");
                            break;
                    }
                    //
                    if (w != null)
                    {
                        roboter.WerkzeugHinzufuegen(platz, w);
                        Ausgabe.Clear();
                    }
                    return;

                }  
            }
            static void WerkzeugEntfernenMenue(Industrieroboter roboter)
            {
                Console.Write("Platz: ");
                string text6 = Console.ReadLine();
                int platz = Eingabe.Zahl(text6);    
                roboter.WerkzeugEntfernen(platz);
                Ausgabe.Clear();
            }
            static void WerkzeugBenutzenMenue(Industrieroboter roboter)
            {
                Console.Write("Platz: ");
                string text7 = Console.ReadLine();
                int platz = Eingabe.Zahl(text7);

                Werkzeug w = roboter.GetWerkzeug(platz);
                if (w == null)
                {
                    Console.WriteLine("Platz ist leer.");
                    return;
                }

                Console.Write("Verschleiß erhöhen um: ");
                string text8 = Console.ReadLine();
                int wert = Eingabe.Zahl(text8);

                w.Verschleiss = Math.Min(100, w.Verschleiss + wert);

                Console.WriteLine("Neuer Verschleiß: " + w.Verschleiss + "%");
                Ausgabe.Clear();
            }
            static void WerkzeugWartenMenue(Industrieroboter roboter)
            {
                Console.Write("Platz: ");
                string text9 = Console.ReadLine();
                int platz = Eingabe.Zahl(text9);

                Werkzeug w = roboter.GetWerkzeug(platz);
                if (w == null)
                {
                    Console.WriteLine("Platz ist leer.");
                    return;
                }

                w.Verschleiss = 0;
                Console.WriteLine("Verschleiß zurückgesetzt.");
                Ausgabe.Clear();
            }

        }

    }
}
