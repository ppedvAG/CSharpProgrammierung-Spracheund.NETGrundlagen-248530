namespace Taschenrechner
{
    class Program
    {
        enum Rechenoperation
        {
            Addition = 1,
            Subtraktion,
            Multiplikation,
            Division
        }
        static void Main(string[] args)
        {
            do
            {
                // Eingabe und Parsing der Ersten Zahl
                Console.WriteLine("Gib eine Zahl ein: ");
                double zahl1 = double.Parse(Console.ReadLine());

                // Eingabe und Parsing der Zweiten Zahl
                Console.WriteLine("Gib eine weitere Zahl ein: ");
                double zahl2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Wähle eine Rechenoperation");

                //foreach (Rechenoperation ope in Enum.GetValues<Rechenoperation>())
                //{
                //    Console.WriteLine($"{(int)ope}: {ope}");
                //}
                for(int i = 1; i <= Enum.GetValues<Rechenoperation>().Length; i++)
                {
                    Console.WriteLine($"{i}: {(Rechenoperation)i}");
                }

                // Abfrage der Benutzereingabe
                Console.WriteLine("Auswahl:");
                Rechenoperation ope = (Rechenoperation)int.Parse(Console.ReadLine());

                // Deklaration und Initialisierung der Ergebnisvariablen
                double ergebnis = 0.0;

                switch (ope)
                {
                    case Rechenoperation.Addition:
                        ergebnis = zahl1 + zahl2;
                        break;
                    case Rechenoperation.Subtraktion:
                        ergebnis = zahl1 - zahl2;
                        break;
                    case Rechenoperation.Multiplikation:
                        ergebnis = zahl1 * zahl2;
                        break;
                    case Rechenoperation.Division:
                        //Prüfung ob eine Teilung durch null möglich wäre
                        if (zahl2 == 0)
                        {
                            Console.WriteLine("Eine Division durch 0 ist nicht erlaubt");
                            Console.WriteLine("Wiederholen (Y/N)");
                            continue;
                        }
                        ergebnis = zahl1 / zahl2;
                        break;
                    default:
                        Console.WriteLine("Fehlerhafte Eingabe bei der Auswahl");
                        Console.WriteLine("Wiederholen (Y/N)");
                        continue;
                }

                Console.WriteLine($"\n Ergebnis : {ergebnis}");




                Console.WriteLine("Wiederholen? (Y/N)");
            } while (Console.ReadKey(true).Key == ConsoleKey.Y);

        }
    }
}











