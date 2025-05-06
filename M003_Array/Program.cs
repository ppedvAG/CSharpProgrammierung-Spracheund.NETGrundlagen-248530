#region Arrays

//Array: Container, die mehrere Variablewerte halten kann
// Alle Werte müssen den gleichen Typen haben

// using System.Threading.Channels;
// using System
// using System.IO
// using System.Linq

// Direkte Initialisierung
int[] zahlen = new int[] { 1, 2, 3, 4, 5, 6 }; //Hier keine Größe angeben

int[] zahlen2 = new[] {1, 2,3, 4, 5, 6, 7 };
int[] zahlen3 = {1, 2, 3, 4, 5, 6, 7 };
int[] zahlen4 = [1, 2, 3, 4, 5, 6, 7, 8]; // Ab .NET 8.0

zahlen[0] = 10;
Console.WriteLine(zahlen[0]); // Arrays ausgeben

// Funktionen

// Length: Gibt die Anzahl der Pläze im Array aus
Console.WriteLine(zahlen.Length);

// Contains: Prüft, ob ein bestimmter Wert im Array vorhanden ist
zahlen.Contains(3); // Ist 3 im Array "zahlen" enthalten?
Console.WriteLine(zahlen.Contains(3));

// Mehrdimensionale Arrays
int[,] zweidimensional;
zweidimensional = new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };

Console.WriteLine(zweidimensional[0, 3]);


#endregion

#region Bedingungen

// If - Bedingung
// Führt den Code aus, wenn die Bedingung true ist

// Vergleichsoperatoren
// == , != (gleich, ungleich)
// >, <= (größer, kleiner-gleich)
// <, >= (kleiner, größer-gleich)

string Hallo = "Hallo";
string Welt = "Welt";

//if (Hallo > Welt) { } //Unlogisch, nicht möglich
if(Hallo.Length > Welt.Length) { Console.WriteLine("Hallo ist länger als Welt"); }

// Logische Operatoren
// && (und)
// || (oder)
// ! (nicht)
// ^ (exklusiv-oder, XOR) "Caret"

int z1 = 5;
int z2 = 8;
int z3 = 12;

if(z1 > z2 && z1 > z3)
{
    // Hier müssen beide Bedingungen gültig sein
    Console.WriteLine("z1 ist größer als z2 & z3");
}

if(z1 > z2 || z1 > z3)
{
    // Hier müssen beide Bedingungen gültig sein
    Console.WriteLine("z1 ist größer als z2 oder z3");
}

if(z1 > z2 ^ z1 > z3)
{
    // Hier muss eine der beiden Bedingungen wahr sein, aber nicht beide
    Console.WriteLine("z1 ist größer als z2 oder z3, aber nicht größer als beide");
}

// Not (!)
if(!zahlen.Contains(10))
{
    // Prüft, ob 10 NICHT enthalten ist
}

if(zahlen.Contains(10))
{
    // Prüft, ob die 10 enthalten ist
}

if(z1 > z2)
{
    // Bedingung A war erfolgreich
} 
else if (z1 == z2)
{
    // Bedingung A war falsch, Bedingung B ist erfolgreich
}
else
{
    // Bedingung A und B waren falsch, else wird ausgeführt
}

// Ternary Operator / Konditionaloperator
// Bedingung ? True-Wert : False-Wert;
// Wann kann ich den Ternary-Operator nutzen?
// => Wenn die Ausgabe nur 1 Befehl hat
string x = z1 > z2 ? "z1 ist größer als z2" : "z1 ist kleiner als z2";
Console.WriteLine(x);

#endregion