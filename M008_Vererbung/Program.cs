namespace M008_Vererbung;

internal class Program
{
    static void Main(string[] args)
    {
        Mensch m = new Mensch(30, "Max");
        m.Alter = 50;
        m.Bewegen(10);

        Kind k = new Kind(1, "M4");
        k.Bewegen(5);
    }
}

public class Lebewesen
{
    public int Alter { get; set;}

    // virutal & override
    // eine mit virtual gekennzeichnete Methode kann in den Unterklassen überschrieben werden
    // Normale Methoden können nicht überschrieben werden
    // Mithilfe des override Keywords kann eine Überschreibung erzeugt werden

    public virtual void Bewegen(int distanz)
    {
        Console.WriteLine($"Lebewesen bewegt sich um {distanz}m");
    }

    public Lebewesen(int alter)
    {
        this.Alter = alter;
    }   
}

public class Mensch : Lebewesen
{
   

    public string Name { get; set; }

    // Konstruktor 
    public Mensch(int alter, string name) : base(alter)
    {
        this.Name = name;   
    }

    // sealed => Verhindert überschreibungen
    public /*sealed*/ override void Bewegen(int distanz)
    {
        Console.WriteLine($"{Name} bewegt sich um {distanz}m und ist {Alter} Jahre alt");
    }
}

public class Kind : Mensch
{
    public Kind(int alter, string name) : base(alter, name)
    {
    }

    public override void Bewegen(int distanz)
    {
        //base.Bewegen(distanz);
        Console.WriteLine($"{Name} krabbelt sich um {distanz}m (bmw geschwindigkeit)");
    }
}

