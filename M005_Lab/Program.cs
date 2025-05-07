public class Program
{
    enum Rechenoperation { Add = 1, Sub, Mult, Div }
    static void Main(string[] args)
    {
        while (true) 
        {
            double zahl1 = Zahleingabe("Gib eine Zahl ein: ");
            double zahl2 = Zahleingabe("Gib eine weitere Zahl ein: ");

            foreach (Rechenoperation rechenoperation in Enum.GetValues<Rechenoperation>())
            {
                Console.WriteLine($"{(int)rechenoperation}: {rechenoperation}");
            }

            Rechenoperation op = RechenoperationEingabe();

            double ergebnis = Berechne(zahl1, zahl2, op);

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                break;
            }
        }
    }

    static double Berechne(double zahl1, double zahl2, Rechenoperation op)
    {
        switch (op)
        {
            case Rechenoperation.Add:
                 return zahl1 + zahl2;
            case Rechenoperation.Sub:
                return zahl1 - zahl2;
            case Rechenoperation.Mult:
                return zahl1 * zahl2;
            case Rechenoperation.Div:
                //Prüfung ob eine Teilung durch null möglich wäre
                if (zahl2 == 0)
                    return double.NaN;

                Console.WriteLine($"{zahl1} / {zahl2} = {zahl1 / zahl2}");
                return zahl1 / zahl2;
            default:
                Console.WriteLine("Fehlerhafte Eingabe bei der Auswahl");
                return double.NaN;
        }
    }

    static double Zahleingabe(string text)
    {   
        while(true)
        {
            Console.WriteLine(text);
            bool funktioniert = double.TryParse(Console.ReadLine(), out double ergebnis);
            if(funktioniert)
            {
                return ergebnis;
            } else
            {
                Console.WriteLine("Keine Zahl eingegeben");
            }
        }
    }

    static Rechenoperation RechenoperationEingabe()
    {   
        while(true)
        {
            double ergebnis = Zahleingabe("Gib eine Rechenoperation ein:");
            Rechenoperation op = (Rechenoperation)ergebnis;
            if (Enum.IsDefined(op))
                return op;
            else
                Console.WriteLine("Keine gültige Rechenoperation eingegeben");
        }
    }
}