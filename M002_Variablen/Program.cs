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



#endregion