#region Schleifen

// Schleifen
// Bestimmten Code mehrmals ausführen

// while
int a = 0;
int b = 10;
while(a < b)
{
    Console.WriteLine($"while: {a}");
    a++;
}

// do-while
a = 0;

do
{
    Console.WriteLine($"do-while: {a}");
    a++;
} while(a < b);

// for-schleife
for(int i = 0; i< b; i++)
{
    Console.WriteLine($"for: {i}");
}

// break und continue

//break: Beendet die schleife
// break wird gerne mit switch & ifs verwendet

// continue: Überspringt den Code danach, und geht zum Schleifenkopf zurück
// wird auch mit if kombiniert

a = 0;
while(a < b)
{
    a++;
    if (a % 2 == 0)
        continue;
    Console.WriteLine($"while continue: {a}");
}

// Iterieren über Array
int[] zahlen = [1, 2, 3, 4, 5, 6];
for(int i = 0; i < zahlen.Length; i++)
{
    Console.WriteLine($"Array: {zahlen[i]}");
}   

// foreach-Schleife
// Foreach hat keinen Zähler sondern nur das element selbst
// Regel Nr.1: Die Foreach-Schleife wird der For-Schleife bevorzugt wenn möglich
foreach(var element in zahlen)
{
    Console.WriteLine(element);
}
#endregion

#region Enums

// Enum
// Liste von Konstanten
// Eigener Typ 
// Hintergrund: Über eine Enumvariable können mögliche Zuständen eingeschränkt werden


Wochentag wt = Wochentag.Di;
if(wt == Wochentag.Di)
{
    Console.WriteLine("Jetzt ist Dienstag immer genau ein Zustand");
}

// Die Enum Klasse => Enum Wochentag in variable speichern
Wochentag[] tage = Enum.GetValues<Wochentag>();
foreach(Wochentag w in tage)
{
    Console.WriteLine($"Enum Wochentag: {w}");
    Console.WriteLine($"Enum Wochentag (int): {(int)w}");
}

// Enum.Parse: Text zu einem Enumwert konvertieren
Console.WriteLine(Enum.Parse<Wochentag>("Mo"));
Console.WriteLine(Enum.Parse<Wochentag>("4"));

#endregion

#region Switch

// Switch => dasselbe wie If, bloß anders geschrieben
Wochentag t = Wochentag.Fr;
if(t == Wochentag.Mo || t == Wochentag.Di || t == Wochentag.Mi || t == Wochentag.Do || t == Wochentag.Fr)
{
    Console.WriteLine("Wochentag");
}
else if (t == Wochentag.Sa || t == Wochentag.So)
{
    Console.WriteLine("Wochenende");
}
else
{
    Console.WriteLine("Fehler!");
}

// jetzt im switch..
switch(t)
{
    case Wochentag.Mo:
    case Wochentag.Di:
    case Wochentag.Mi:
    case Wochentag.Do:
    case Wochentag.Fr:
        Console.WriteLine("Wochentag");
        break;
    case Wochentag.Sa:
    case Wochentag.So:
        Console.WriteLine("Wochenende");
        break;
    default:
        Console.WriteLine("Fehler");
        break;
}

// boolscher Switch
switch(t)
{
    case >= Wochentag.Mo and <= Wochentag.Fr:
        Console.WriteLine("Wochentag");
        break;
    case Wochentag.Sa or Wochentag.So:
        Console.WriteLine("Wochenende");
        break;
    default:
        Console.WriteLine("Fehler");
        break;
}

for(int i = 0; i < 100; i++)
{
    if(i % 5 == 0)
        Console.WriteLine(i);
        continue;
}

#endregion

enum Wochentag
{
    Mo = 1, Di, Mi, Do, Fr, Sa, So
}