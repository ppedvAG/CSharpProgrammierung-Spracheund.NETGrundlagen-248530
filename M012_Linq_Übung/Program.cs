using System.Diagnostics;
using System.Text.Json;

namespace M012;

internal class Program
{
    static void Main(string[] args)
    {
        #region File lesen
        string readJson = File.ReadAllText(@"..\..\..\Personen.json");
        List<Person> personen = JsonSerializer.Deserialize<List<Person>>(readJson)!;
        #endregion

        //Hier eigenen Code schreiben
        // 24, 37, 42, 55, 59, 68, 
        // Personen über 60 Jahre alt
        personen.Where(e => e.Alter >= 60);

        personen.Any(e => e.Alter >= 50 && e.Job.Gehalt >= 2000);

        personen.Where(e => e.Vorname[0] == 'M' && e.Nachname[0] == 'S');
        personen.Where(e => e.Vorname.StartsWith('M') && e.Nachname.StartsWith('S'));

    }
}

///////////////////////////////////////////////////////////////////////////////

[DebuggerDisplay("Person - ID: {ID}, Vorname: {Vorname}, Nachname: {Nachname}, GebDat: {Geburtsdatum.ToString(\"yyyy.MM.dd\")}, Alter: {Alter}, " +
    "Jobtitel: {Job.Titel}, Gehalt: {Job.Gehalt}, Einstellungsdatum: {Job.Einstellungsdatum.ToString(\"yyyy.MM.dd\")}")]
public record Person(int ID, string Vorname, string Nachname, DateTime Geburtsdatum, int Alter, Beruf Job, List<string> Hobbies);

public record Beruf(string Titel, int Gehalt, DateTime Einstellungsdatum);

///////////////////////////////////////////////////////////////////////////////