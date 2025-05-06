#region Variablen

// Kommentare
//Mit zwei Slashes kann ein Kommentar definiert werden
// Wird vom Compiler ignoriert

/*
    Mehrzeiliger

    Kommentarblock
*/

// Hotkey Kommentieren = [STRG + K][STRG + C]
// Zeile kopieren(nach unten) STRG + D
// Hotkey auskommentieren = [STRG + K][STRG + U]

// Variable
// Behälter für einen Wert
// Brauchen wir immer in der Programmierung
// Aufbau: <Datentyp> <Name> = <Wert>;

int Zahl = 10;

Console.WriteLine(Zahl); // cw + Tab
Console.WriteLine(Zahl * 2);

// Datentype
// Geben an, welchen Inhalt eine Variable haben darf

// Ganzzahlige Typen: int, long, short, byte
int i = 23;
long l = 23;
short s = 23;
byte b = 23;

// Kommazahlentypen: double, float, decimal
double kommazahl = 23.65;
Console.WriteLine("Die Kommazahl beträgt: " + kommazahl);

float f = 23.65f; // Jede Kommazahl in C# ist standardmäßig ein Double, mit f am Ende kann eine konvertierung durchgeführt werden

decimal d = 23.65m; // Mit dem M-suffix = decimal

string str = "Hallo, ich bin ein String"; // Strings werden in Hochkommas angegeben "doppelte"
Console.WriteLine(str);

char c = 'a'; // Char werden in einzelnen Hochkommas angegeben

// Bool: true oder false
bool wahr = true;
bool falsch = false;

#endregion

#region Strings

string Ergebnis = "Die Zahl mal zwei ist: " +  Zahl * 2;
Console.WriteLine(Ergebnis);

// $-Prefix (String-Interpolation)
Console.WriteLine($"Der double ist: {kommazahl * 3}, der float ist: {f * 5}, der decimal ist: {d}");

// Escape Sequenzen: Untippbaren Zeichen in Strings
// https://learn.microsoft.com/de-de/cpp/c-language/escape-sequences?view=msvc-170
Console.WriteLine("Zeilenumbruch \n Zeilenumbruch");
Console.WriteLine("Tabulator \t Tabulator");
Console.WriteLine("War das wirklich ein \"Spaß\"?");

// Verbatim-String
string pfad = @"C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.1\System.Security.AccessControl.dll";
#endregion

#region Eingabe

// Console.Readline(): Wartet auf die Eingabe des Benutzers und speichert diese in die Variable
//Console.WriteLine("\n\n");
//Console.WriteLine("String Eingabe: ");
//string eingabe = Console.ReadLine();
//Console.WriteLine($"Du hast {eingabe} eingebeben");

// Console.ReadKey(): Wartet auf die einzelne Eingabe vom Benutzer
//ConsoleKeyInfo taste = Console.ReadKey();
//Console.WriteLine(taste.Key);

#endregion

#region Konvertierungen

// Konvertierung: Umwandlung von einem Typen zu einem anderen Typen
string userEingabe = Console.ReadLine();

// String zu Zahl umwandeln: Parse
int konvertierung = int.Parse(userEingabe); // Umwandlung von Text zu Int
Console.WriteLine($"Deine Zahl mal zwei ist:  {konvertierung * 2}");

// Zahl zu String umwandlung ToString()
Console.WriteLine(konvertierung.ToString());

// Zahl zu Zahl: cast
double grosseZahl = 2133181.28;
Console.WriteLine(grosseZahl);

int x = (int)grosseZahl;
Console.WriteLine(x);

#endregion

#region Arithmetik

int zahl1 = 3;
int zahl2 = 7;
int Test = 3 + 10 - 5 / 2;

// Aufgabe
// Zahl2 auf zahl 1 addieren
int Erg = zahl2 + zahl1;
zahl1 += zahl2; // zahl1 = zahl1 + zahl2
zahl1 = zahl1 + zahl2;

// Modulo (%): Rest einer Divison
Console.WriteLine(8 % 5); // 3R

// ++, --
zahl1++; // eins dazu addieren
zahl2--; // eins subtrahieren

// Math: Mathematischen Funktionen
double gerundet = Math.Round(2.456637, 2); // Auf 2 Kommastellen runden
Console.WriteLine(gerundet);

// Divisionsprobleme
Console.WriteLine(8 / 5); // 1, wenn zwei ints dividiert werden, kommt auch int heraus
Console.WriteLine(8 / 5.0); // Wenn eine der beiden Zahlen eine Kommazahl ist, kommt auch eine kommazahl raus
Console.WriteLine(8 / 5d);
Console.WriteLine(8m / 5);
Console.WriteLine(8f / 5);
Console.WriteLine(zahl1);
Console.WriteLine(zahl2);
Console.WriteLine((double)zahl1 / zahl2); // 18 / 6 = 3
Console.WriteLine((double)8 / 5);


#endregion