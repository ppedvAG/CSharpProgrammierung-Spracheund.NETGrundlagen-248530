// 1. Erstelle eine Basisklasse Fahrzeug
// ----------------------------------
// - Eigenschaften: Marke, Modell, Baujahr, Preis
// - Eine virtuelle Methode AnzeigeDetails(), die die Fahrzeugdetails ausgibt

// 2. Erstelle abgeleitete Klassen Auto und Motorrad
// ----------------------------------------------
// - Auto hat zusätzlich AnzahlTueren
// - Motorrad hat zusätzlich HatBeiwagen (bool)
// - Überschreibe AnzeigeDetails() in beiden Klassen

// 3. Nutze ein Interface IFahrzeugAktionen, das Methoden für Starten() und Stoppen() definiert
// ----------------------------------------------------------------------------------------
// - Implementiere es in Auto und Motorrad

// 4. Erstelle eine Klasse Fuhrpark, die eine Liste von Fahrzeugen (Array) speichert
// ---------------------------------------------------------------------------------
// - Methode FahrzeugeHinzufuegen(Fahrzeug[] neueFahrzeuge), um Fahrzeuge zur Liste hinzuzufügen
// - Methode AlleFahrzeugeAnzeigen(), die alle gespeicherten Fahrzeuge auflistet
// - Eine Methode FahrzeugeFilternNachPreis(decimal maxPreis), die mit LINQ alle Fahrzeuge unterhalb eines bestimmten Preises filtert und zurückgibt
// - Eine Methode FahrzeugeSortierenNachBaujahr(), die die Fahrzeuge nach Baujahr sortiert

// 5. Hauptprogramm (Main-Methode)
// -------------------------------
// - Erstelle mehrere Autos und Motorräder
// - Füge sie dem Fuhrpark hinzu
// - Rufe die Methoden zur Anzeige, Filterung und Sortierung auf

using System;
using System.Collections.Generic;
using System.Linq;

// Interface für Fahrzeugaktionen
interface IFahrzeugAktionen
{
    void Starten();
    void Stoppen();
}

// Basisklasse Fahrzeug
public class Fahrzeug
{
    public string Marke { get; set; }
    public string Modell { get; set; }
    public int Baujahr { get; set; }
    public decimal Preis { get; set; }

    public Fahrzeug(string marke, string modell, int baujahr, decimal preis)
    {
        Marke = marke;
        Modell = modell;
        Baujahr = baujahr;
        Preis = preis;
    }

    public virtual void AnzeigeDetails()
    {
        Console.WriteLine($"{Marke} {Modell}, Baujahr: {Baujahr}, Preis: {Preis:C}");
    }
}

// Abgeleitete Klasse Auto
class Auto : Fahrzeug, IFahrzeugAktionen
{
    public int AnzahlTueren { get; set; }

    public Auto(string marke, string modell, int baujahr, decimal preis, int anzahlTueren)
        : base(marke, modell, baujahr, preis)
    {
        AnzahlTueren = anzahlTueren;
    }

    public override void AnzeigeDetails()
    {
        Console.WriteLine($"{Marke} {Modell} (Auto), Baujahr: {Baujahr}, Türen: {AnzahlTueren}, Preis: {Preis:C}");
    }

    public void Starten() { Console.WriteLine($"{Marke} {Modell} startet."); }
    public void Stoppen() { Console.WriteLine($"{Marke} {Modell} stoppt."); }
}

// Abgeleitete Klasse Motorrad
class Motorrad : Fahrzeug, IFahrzeugAktionen
{
    public bool HatBeiwagen { get; set; }

    public Motorrad(string marke, string modell, int baujahr, decimal preis, bool hatBeiwagen)
        : base(marke, modell, baujahr, preis)
    {
        HatBeiwagen = hatBeiwagen;
    }

    public override void AnzeigeDetails()
    {
        string beiwagenText = HatBeiwagen ? "mit Beiwagen" : "ohne Beiwagen";
        Console.WriteLine($"{Marke} {Modell} (Motorrad), Baujahr: {Baujahr}, {beiwagenText}, Preis: {Preis:C}");
    }

    public void Starten() { Console.WriteLine($"{Marke} {Modell} startet."); }
    public void Stoppen() { Console.WriteLine($"{Marke} {Modell} stoppt."); }
}

// Klasse Fuhrpark
class Fuhrpark
{
    private List<Fahrzeug> fahrzeuge = new List<Fahrzeug>();

    public void FahrzeugeHinzufuegen(Fahrzeug[] neueFahrzeuge)
    {
        fahrzeuge.AddRange(neueFahrzeuge);
    }

    public void AlleFahrzeugeAnzeigen()
    {
        Console.WriteLine("\nListe aller Fahrzeuge:");
        foreach (var fahrzeug in fahrzeuge)
        {
            fahrzeug.AnzeigeDetails();
        }
    }

    public List<Fahrzeug> FahrzeugeFilternNachPreis(decimal maxPreis)
    {
        return fahrzeuge.Where(f => f.Preis <= maxPreis).ToList();
    }

    public void FahrzeugeSortierenNachBaujahr()
    {
        fahrzeuge = fahrzeuge.OrderBy(f => f.Baujahr).ToList();
    }
}

// Hauptprogramm
class Program
{
    static void Main()
    {
        // Fahrzeuge erstellen
        Auto auto1 = new Auto("BMW", "3er", 2020, 35000m, 4);
        Auto auto2 = new Auto("Audi", "A4", 2018, 28000m, 4);
        Motorrad motorrad1 = new Motorrad("Yamaha", "R1", 2022, 15000m, false);
        Motorrad motorrad2 = new Motorrad("Harley-Davidson", "Sportster", 2019, 18000m, true);

        // Fuhrpark erstellen und Fahrzeuge hinzufügen
        Fuhrpark fuhrpark = new Fuhrpark();
        fuhrpark.FahrzeugeHinzufuegen(new Fahrzeug[] { auto1, auto2, motorrad1, motorrad2 });

        // Alle Fahrzeuge anzeigen
        fuhrpark.AlleFahrzeugeAnzeigen();

        // Fahrzeuge nach Preis filtern (bis 20.000€)
        Console.WriteLine("\nFahrzeuge unter 20.000€:");
        var guenstigeFahrzeuge = fuhrpark.FahrzeugeFilternNachPreis(20000m);
        foreach (var f in guenstigeFahrzeuge)
        {
            f.AnzeigeDetails();
        }

        // Fahrzeuge nach Baujahr sortieren und erneut anzeigen
        fuhrpark.FahrzeugeSortierenNachBaujahr();
        Console.WriteLine("\nFahrzeuge sortiert nach Baujahr:");
        fuhrpark.AlleFahrzeugeAnzeigen();

        // Fahrzeugaktionen testen
        Console.WriteLine("\nFahrzeugaktionen:");
        auto1.Starten();
        auto1.Stoppen();
        motorrad1.Starten();
        motorrad1.Stoppen();
    }
}
