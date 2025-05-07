namespace M007_GC_Static;

internal class Program
{
    static void Main(string[] args)
    {
        // Static Methode
        // Eine Methode als Static deklarieren, dann kann ich sie OHNE ein Objekt der Klasse aufrufen
        int summe = Mathe.Adddiere(3, 5);
        Console.WriteLine(summe);

        // Statische Variable
        // eine Static Variable wird von allen Objekten geteilt
        new Auto();
        new Auto();
        new Auto();
        Auto.AnzahlAutos += 1;
        Console.WriteLine(Auto.AnzahlAutos);

        // Statische Klasse
        // eine static-Klasse kann nicht instanziiert werden (keine Objekterstellung möglich)
        // Wofür sinnvoll?: Eine Sammlung von statischen Methoden
        //Helfer h1 = new Helfer();
        Helfer.ZeigeText();


        Person person = new Person("Test");
        person = null; // Setzt das Objekt auf null == Speicher frei geben, Objekt zerstören

        for (int i = 0; i < 5; i++) 
        {
            Person p = new Person("Test");
            Person p1 = new Person("Test");
            //p = null;
            //p1 = null;
        }

        //p1 = null; // Setzt das Objekt auf null == Speicher frei geben, Objekt zerstören

        GC.Collect(); // Erzwingt eine Garbage Collection
        GC.WaitForPendingFinalizers(); // Wartet auf die Abarbeitung des Destruktors
        Console.WriteLine("Programm beendet");
    }
}

class Mathe
{
    public static int Adddiere(int a, int b)
    {
        return a + b;
    }
}

class Auto
{
    public static int AnzahlAutos = 0;
    public Auto()
    {
        AnzahlAutos++;
    }
}

static class Helfer
{
    public static void ZeigeText()
    {
        Console.WriteLine("Hallo!");
    }
}

public class Person
{
    public string Vorname { get; set; }
    public Person(string vorname)
    {
        Vorname = vorname;
    }

    ~Person()
    {
        Console.WriteLine("Objekt wurde zerstört");
    }
}