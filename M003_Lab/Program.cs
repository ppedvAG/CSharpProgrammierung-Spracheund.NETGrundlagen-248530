
#region Schaltjahr

// Abfrage der Eingabe
Console.WriteLine("Gib das Jahr ein");
int eingabe = int.Parse(Console.ReadLine());

// Deklarierung/Initialisierung der bool-Variable
bool istSchaltjahr = false;

// Prüfungen
if (eingabe % 4 == 0)
{
    istSchaltjahr = true;

    if (eingabe % 100 == 0)
    {
        istSchaltjahr = false;

        if (eingabe % 400 == 0)
            istSchaltjahr = true;
    }
}

Console.WriteLine($"{eingabe} ist Schaltjahr: {istSchaltjahr}");



#endregion

#region Lotto

// ARRAY deklarieren
int[] gewinnzahlen = { 3, 10, 15, 19, 99, 45, 25 };

// Abfragen
Console.WriteLine("Bitte gib deinen Tipp (Ganzzahl zwischen 0 - 100):");
int tipp = int.Parse(Console.ReadLine());

if (tipp < 0 || tipp > 100)
    Console.WriteLine("Dein Tipp ist außerhalb des Gültigkeitsbereich");
else
{
    if(gewinnzahlen.Contains(tipp))
        Console.WriteLine("Glückwunsch!!! Du hast eine der sieben Geheimzahlen getippt");
    else
        Console.WriteLine("Leider daneben. Viel glück beim nächsten Mal!");
}

#endregion