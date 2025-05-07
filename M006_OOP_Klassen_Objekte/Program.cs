using M006_OOP_Klassen_Objekte.Data;

namespace M006_OOP_Klassen_Objekte;

// Klassen und Objekte
/*
    Objekte sind Datenstrukturen, welche Daten halten
    Jedes Objekt kommt von einer Klasse
    Die Klasse hinter den Objekten gibt den Aufbaue der Objekte vor

    WICHTIG: In der Klase selber werden keine konkreten Werte definiert
    sondern erst beim Erstellen des Objektes
*/
internal class Program
{
    static void Main(string[] args)
    {
        // Erstellen von Person p1
        Person p1 = new Person();

        // manuell setzen
        p1.SetVorname("Udo");
        p1.Nachname = "Mustermann";
        p1.Alter = 20;

        Console.WriteLine($"{p1.GetVorname()} {p1.Nachname} ist {p1.Alter}");

        Person p2 = new Person("Max", "Mustermann", 20);

        Console.WriteLine($"{p2.GetVorname()} {p2.Nachname} ist {p2.Alter}");


        // Schulung
        Schulung s = new Schulung(p1, "Berlin", Schulungstyp.Praesenz, 4, "C# Grundkurs", p1, p2);

        Console.WriteLine($"Der Trainer {s.Trainer.GetVorname()} {s.Trainer.Nachname}, der Ort: {s.Standort}, die Teilnehmer: {s.Teilnehmer[1].GetVorname()} {s.Teilnehmer[1].Nachname}, {s.Teilnehmer[0].GetVorname()} {s.Teilnehmer[0].Nachname}");
    
        foreach (Person teilnehmer in s.Teilnehmer)
        {
            Console.WriteLine(teilnehmer.GetVorname() + teilnehmer.Nachname);
        }
    }
}