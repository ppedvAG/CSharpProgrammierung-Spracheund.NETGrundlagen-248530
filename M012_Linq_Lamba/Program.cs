namespace M012_Linq_Lambda;

public class Program
{
    static void Main(string[] args)
    {
        #region Einfaches Linq

        // IEnumerable
        // Beispiel Daten
        // Zufällig erstellen
        IEnumerable<int> zahlen = Enumerable.Range(0, 1_000_000);

        // Insgesamt 20001
        List<int> ints = Enumerable.Range(1, 20000).ToList();

        Console.WriteLine(ints.Average());
        Console.WriteLine(ints.Min());
        Console.WriteLine(ints.Max());
        Console.WriteLine(ints.Sum());

        // WICHTIG: Jede Linq Funktion fängt mit einem e => an
        // Suchen das erste Element was durch 50 Teilbar ist
        Console.WriteLine(ints.FirstOrDefault(e => e % 50 == 0));

        #endregion

        #region Linq mit Objekten

        List<Fahrzeug> fahrzeuge = new List<Fahrzeug>()
        {
            new Fahrzeug(250, FahrzeugMarke.BMW),
            new Fahrzeug(270, FahrzeugMarke.Mercedes),
            new Fahrzeug(180, FahrzeugMarke.Audi),
            new Fahrzeug(225, FahrzeugMarke.Audi),
            new Fahrzeug(542, FahrzeugMarke.BMW),
            new Fahrzeug(132, FahrzeugMarke.Mercedes),
            new Fahrzeug(150, FahrzeugMarke.Mercedes),
        };

        // Alle BMWs finden
        List<Fahrzeug> bmws = fahrzeuge.Where(e => e.Marke == FahrzeugMarke.BMW).ToList();

        // ELemente ausgeben
        foreach(var item in bmws)
        {
            Console.WriteLine($"MaxGeschwindigkeit: {item.MaxV}, FahrzeugMarke: {item.Marke}");
        }

        // Alle Autos finden die über 220km fahren
        List<Fahrzeug> maxv = fahrzeuge.Where(e => e.MaxV >= 220).ToList();

        foreach(var item in maxv)
        {
            Console.WriteLine($"MaxGeschwindigkeit: {item.MaxV}, Und Fahrzeug... {item.Marke}");
        }

        // Alle Autos finden die über 220km fahren und BMWs sind
        List<Fahrzeug> test = fahrzeuge.Where(e => e.MaxV >= 220).Where(e => e.Marke == FahrzeugMarke.BMW).ToList();
        List<Fahrzeug> hallo = fahrzeuge.Where(e => e.MaxV >= 220 && e.Marke == FahrzeugMarke.BMW).ToList();


        // Alle Fahrzeuge nach Marke, MaxV sortieren
        List<Fahrzeug> sortieren = fahrzeuge.OrderBy(e => e.Marke).ThenBy(e => e.MaxV).ToList();
        List<Fahrzeug> absteigend = fahrzeuge.OrderByDescending(e => e.Marke).ThenByDescending(e => e.MaxV).ToList();




        #endregion
    }
}

public class Fahrzeug
{
    public int MaxV;
    public FahrzeugMarke Marke;

    public Fahrzeug(int maxV, FahrzeugMarke marke)
    {
        MaxV = maxV;
        Marke = marke;
    }
}

public enum FahrzeugMarke
{
    Audi, BMW, Mercedes
}