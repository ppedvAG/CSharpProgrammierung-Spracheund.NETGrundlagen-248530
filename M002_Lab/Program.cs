// Variablendeklarierung

int entfernungInMeter, stunden, minuten, sekunden;
double meterProSekunde, kilometerProStunde, meilenProStunde;

// Abfrage der Eingaben
Console.WriteLine("Bitte gib folgenden Angaben ein:");

Console.WriteLine("Entfernung in Meter: ");
// Parsen der Eingabe
entfernungInMeter = int.Parse(Console.ReadLine());

Console.WriteLine("Stunden: ");
stunden = int.Parse(Console.ReadLine());

Console.WriteLine("Minuten: ");
minuten = int.Parse(Console.ReadLine());

Console.WriteLine("Sekunden: ");
sekunden  = int.Parse(Console.ReadLine());

// Berechnungen der Ausgabe
sekunden = sekunden + (minuten * 60) + (stunden * 3600);
meterProSekunde = entfernungInMeter / (double) sekunden;
kilometerProStunde = meterProSekunde * 3.6;
meilenProStunde = kilometerProStunde * 0.62137119;

// Ausgaben inkl. Rundungen auf zwei Nachkommastellen
Console.WriteLine($"Meter/Sekunde:\t\t { Math.Round(meterProSekunde, 2)}");
Console.WriteLine($"Kilometer/Stunde:\t {Math.Round(kilometerProStunde, 2)}");
Console.WriteLine($"Meilen/Stunde:\t\t {Math.Round(meilenProStunde, 2)}");