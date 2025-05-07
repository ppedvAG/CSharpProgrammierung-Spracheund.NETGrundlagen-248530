// Funktionen
// Code in Blöcken ablegen und diese Später mehrmals verwenden

// Aufbau
// <Modifier> <Rückgabewert> <Namen>(<Par1>, <Par2>, ...) { Anweisung }

internal class Program
{
    public static void Main(string[] args)
    {
        // PrintAddiere aufrufen
        // Ausgegeben wird das ganze in der PrintAddiere funktion (siehe unten)
        PrintAddiere(4, 6);
        Console.WriteLine($"4A + 6B = {PrintAddiere(4, 6)}");

       
        Console.WriteLine(PrintSubtrahiere(20, 5));

       
        //Console.WriteLine(Addiere(1, 2, 5, 20, 30, 15, 7, 6));
        //Console.WriteLine(Addiere(1,2,3,4));

        Subtrahiere();
         
        Console.WriteLine(Subtrahiere(4, 10)); // c bleibt 0
        Console.WriteLine(Subtrahiere(c: 10, a: 5)); // b überspringen = 0

        int q, r;
        Teile(10, 3, out q, out r);
        Console.WriteLine($"Der Quotient ist {q}, Rest: {r}");

        // TryParse gibt einen bool zurück, der sagt aus, ob parsen funktioniert hat oder nicht
        int ergebnis; // Hier oben muss eine Variable definiert werden, welche über das Ergebnis (bei Erfolg) einfängt
        bool funktioniert = int.TryParse("123", out ergebnis); // Über out ergebnis wird der Paramter mit der Variable verbunden
        if( funktioniert )
        {
            Console.WriteLine($"Zahl: {ergebnis}");
        } else
        {
            Console.WriteLine($"Parsen hat nicht funktioniert");
        }

    }
 
                            // 4        6
    static int PrintAddiere(int z1, int z2)
    {
        //          4    6
        int summe = z1 + z2;
        Console.WriteLine($"{z1} + {z2} = {summe}");
        return summe;
    }

    // Überladung
    // Denselben Funktionsnamen mehrmals verwenden
    // Hierbei müssen sich Parameter unterscheiden (Datentyp oder Parameteranzahl)
    static double PrintAddiere(double z1, double z2)
    {
        double summe = z1 + z2;
        Console.WriteLine($"{z1} + {z2} = {summe}");
        return summe;
    }

    static double PrintAddiere(double z1, double z2, double z3)
    {
        double summe = z1 + z2 + z3;
        Console.WriteLine($"{z1} + {z2} + {z3} = {summe}");
        return summe;
    }

    static string PrintAddiere(string z1, string z2, string z3)
    {
        string summe = z1 + z2 + z3;
        Console.WriteLine($"{z1} + {z2} + {z3} = {summe}");
        return summe;
    }

    //static bool PrintAddiere(string z1, string z2, string z3)
    //{
    //     summe = z1 + z2 + z3;
    //    Console.WriteLine($"{z1} + {z2} + {z3} = {summe}");
    //    return summe;
    //}

    static string PrintSubtrahiere(int z1, int z2)
    {
        int summe = z1 - z2;
        return $"{z1} + {z2} = {summe}";
    }

    // params
    // Ermöglicht, beliebig viele Paramter an die Funktion zu geben
    // Innerhalb er Funktion ist der Params-Parameter ein Array
    // Jede Funktion kann nur ein params-Parameter haben
    static int Addiere(string z1, string z2, params int[] zahlen)
    {
        Console.WriteLine($"Dein Name: {z1} {z2}");
        // return z1 + z2 + zahlen.Sum();
        return zahlen.Sum();
    }

    // optionale Paramter
    // Default-Werte von Parametern, eine gewisse Vorbelegung
    static int Subtrahiere(int a = 0, int b = 0, int c = 0)
    {
        int summe = a - b - c;
        Console.WriteLine(summe);
        return summe;
    }

    // out-Parameter (RÜckgabe mehrerer Werte)
    static void Teile(int zahl, int divisor, out int quotient, out int rest)
    {
        quotient = zahl / divisor;
        rest = zahl % divisor;
    }
}