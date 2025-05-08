using System.Net.Http.Headers;

namespace Fahrzeugpark;

public class Fahrzeug
{
    // Properties
    public string Name { get; set; }
    public int MaxGeschwindigkeit { get; set; }
    public int AktGeschwindigkeit { get; set; }
    public double Preis { get; set; }
    public bool MotorLauft { get; set; }

    public Fahrzeug(string name, int maxGeschwindigkeit, double preis)
    {
        Name = name;
        MaxGeschwindigkeit = maxGeschwindigkeit;
        AktGeschwindigkeit = 0;
        Preis = preis;
        MotorLauft = false;
    }

    public virtual string Info()
    {
        if (this.MotorLauft)
        {
            return $"{this.Name} kostet {this.Preis} und fährt momentan mit {this.AktGeschwindigkeit} von maximal {this.MaxGeschwindigkeit}km/h";
        }
        else
        {
            return $"{this.Name} kostet {this.Preis} und könnte maximal {this.MaxGeschwindigkeit}km/h fahren";
        }
    }

    public void StarteMotor()
    {
        if (this.MotorLauft)
        {
            Console.WriteLine($"Der Motor von {this.Name} läuft bereits");
        }
        else
        {
            this.MotorLauft = true;
            Console.WriteLine($"Der motor von {this.Name} wurde gestartet");
        }
    }

    public void StoppeMotor()
    {
        if (!this.MotorLauft)
        {
            Console.WriteLine($"Der Motor von {this.Name} ist bereits gestoppt");
        }
        else if (this.AktGeschwindigkeit > 0)
            Console.WriteLine($"Der Motor kann nicht gestoppt werden, da sich {this.Name} noch bewegt");
        else
        {
            this.MotorLauft = false;
            Console.WriteLine($"Der Motor von {this.Name} wurde gestoppt");
        }
    }

    public void Beschleunige(int a)
    {
        if (this.MotorLauft)
        {
            if (this.AktGeschwindigkeit + a > this.MaxGeschwindigkeit)
                this.AktGeschwindigkeit = this.MaxGeschwindigkeit;
            else if (this.AktGeschwindigkeit + a < 0)
                this.AktGeschwindigkeit = 0;
            else
                this.AktGeschwindigkeit += a;

            Console.WriteLine($"{this.Name} bewegt sich jetzt mit {this.AktGeschwindigkeit}km/h");
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Fahrzeug fz1 = new Fahrzeug("BMW", 240, 50000);
        Console.WriteLine(fz1.Info() + "\n");

        fz1.StarteMotor();
        fz1.Beschleunige(120);
        Console.WriteLine(fz1.Info() + "\n");

        fz1.Beschleunige(300);
        Console.WriteLine(fz1.Info() + "\n");

        fz1.StoppeMotor();
        Console.WriteLine(fz1.Info() + "\n");

        fz1.Beschleunige(-500);
        fz1.StoppeMotor();
        Console.WriteLine(fz1.Info() + "\n");

        // Instanziieren
        PKW pkw = new PKW("BMW", 300, 5000, 4);
        Schiff schiff = new Schiff("Titanic", 0, 25000000, 4300);
        Flugzeug flugzeug = new Flugzeug("Boeing", 350, 9000000, 8000);

        Console.WriteLine(pkw.Info());
        Console.WriteLine(schiff.Info());
        Console.WriteLine(flugzeug.Info());

        flugzeug.Füllmenge = 50;
        Console.WriteLine(flugzeug.Getankt());

        List<Fahrzeug> fahrzeugs = new List<Fahrzeug>
        {
            new Fahrzeug("BMW", 300, 20000),
            new Fahrzeug("Audi", 300, 25000),
            new Fahrzeug("Mercedes", 3000, 17000)
        };

        foreach (var fah in fahrzeugs)
        {
            Console.WriteLine(fah.Name);
        }

        // Liste erstellen
        List<Fahrzeug> fzh = new List<Fahrzeug>();

        // Befuellen
        for(int i = 0; i < 10; i++)
        {
            fzh.Add(new Fahrzeug($"BMW{i}", 33, 50000));
        }

        // AUsgeben
        foreach(var f in fzh)
        {
            Console.WriteLine(f.Name);
        }
    }
}

public class PKW : Fahrzeug
{
    public int Sitzplaetze { get; set; }

    public PKW(string name, int maxGeschwindigkeit, double preis, int sitzplaetze) : base(name, maxGeschwindigkeit, preis)
    {
        Sitzplaetze = sitzplaetze;
    }

    public override string Info()
    {
        return $"Der PKW {base.Info()}. Er hat {Sitzplaetze} Sitzplätze.";
    }
}

public class Schiff : Fahrzeug
{
    public Schiff(string name, int maxGeschwindigkeit, double preis, double tiefgang) : base(name, maxGeschwindigkeit, preis)
    {
        Tiefgang = tiefgang;
    }

    public double Tiefgang { get; set; }

    public override string Info()
    {
        return $"Das Schiff {base.Info()}. Es taucht in {Tiefgang}m Tiefe";
    }
}

public class Flugzeug : Fahrzeug, ITanken
{
    public int Flughoehe { get; set; }
    public Flugzeug(string name, int maxGeschwindigkeit, double preis, int flughoehe) : base(name, maxGeschwindigkeit, preis)
    {
        Flughoehe = flughoehe;
    }
    public override string Info()
    {
        return $"Das Flugzeug {base.Info()}. Es kann bis auf {Flughoehe}m aufsteigen.";
    }

    public int Füllmenge {  get; set; }
    public string Getankt()
    {
        return $"Ich habe das Flugzeug mit {Füllmenge}L getankt";
    }
}

// Erstelle ein Neues Interface: ITanken
// - Füllmenge
// public string Getankt => gibt einfach eine Nachricht aus, das wir das Fahrzeug getankt haben

public interface ITanken
{
    public int Füllmenge { get; set; }

    public string Getankt();
}