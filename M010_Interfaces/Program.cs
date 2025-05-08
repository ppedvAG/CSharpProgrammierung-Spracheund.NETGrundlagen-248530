namespace M010_Interfaces;

public class Program
{
    static void Main(string[] args)
    {
        Smartphone Iphone = new Smartphone();
        Laptop HP = new Laptop();


        Console.WriteLine("Wähle ein Maximum für dein Iphone aus");
        int ParseEingabe;
        bool funktioniert = int.TryParse(Console.ReadLine(), out ParseEingabe);

        if(funktioniert)
        {
            Iphone.Maximum = ParseEingabe;
            Iphone.Aufladen(50);
            Iphone.PrintLadezustand();
        }
        else
        {
            Console.WriteLine("Fehler, Parsen hat nicht funktioniert");
        }





        //IAufladbar[] aufladbar = [Iphone, HP];

        //// Iphone
        //aufladbar[0].Maximum = 100;
        //aufladbar[0].Aufladen(25);
        //aufladbar[0].PrintLadezustand();

        //// Laptop
        //aufladbar[1].Maximum = 100;
        //aufladbar[1].Aufladen(25);
        //aufladbar[1].PrintLadezustand();
    }
}

public interface IAufladbar
{
    int Ladezustand { get; set; }
    int Maximum {  get; set; }
    public void Aufladen(int x);
    public void PrintLadezustand();
    public double MaxProzent();
}

public class Smartphone : IAufladbar
{
    public int Ladezustand { get; set; }
    public int Maximum { get; set; }

    public void Aufladen(int x)
    {
        if (Ladezustand + x > Maximum || Ladezustand + x < 0)
            return;
        Ladezustand += x;
    }

    public void PrintLadezustand()
    {
        Console.WriteLine($"Das Smartphone ist zu {MaxProzent() * 100}% geladen");
    }

    public double MaxProzent()
    {
        return (double) Ladezustand / Maximum;
    }
}


public class Laptop : Smartphone, IAufladbar
{
    public int Ladezustand { get; set; }
    public int Maximum { get; set; }

    public void Aufladen(int x)
    {
        if (Ladezustand + x > Maximum || Ladezustand + x < 0)
            return;
        Ladezustand += x;
    }

    public void PrintLadezustand()
    {
        Console.WriteLine($"Das Smartphone ist zu {MaxProzent() * 100}% geladen");
    }

    public double MaxProzent()
    {
        return (double)Ladezustand / Maximum;
    }
}