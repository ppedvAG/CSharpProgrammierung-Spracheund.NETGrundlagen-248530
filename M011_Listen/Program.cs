namespace M011_Listen;

// Generischer Datentyp (Generic)

// Platzhalter für ein konkreten Typ
// PLatzhalter wird als "T" bezeichnet
// Wenn hier ein konkreter Typ eingesetzt wird, werden alle "T"s mit einem Datentyp ausgetauscht

public class Program
{
    static void Main(string[] args)
    {
        // List
        // Kann eine beliebige Menge an Daten halten
        // Flexibler als Array
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        // Liste iterieren
        foreach (int i in list)
        {
            Console.WriteLine($"Listelement: {i}");
        }


        List<string> list2 = new List<string>();
        list2.Add("A");
        list2.Add("B");
        list2.Add("C");
        list2.Add("D");
        list2.Add("E");
        
        foreach(string i in list2)
            Console.WriteLine($"Stringliste: {i}");


        // Dictionary
        // Liste von Schlüssel-Wert-Paaren
        // Jeder Schlüssel hat einen angehängten Wert
        // Das Dictionary hat zwei Generics (1: Schlüssel, 2. Wert)
        Dictionary<int, string> dict = new Dictionary<int, string>();

        dict.Add(1, "Wien");
        dict.Add(2, "Berlin");
        dict.Add(3, "Burghausen");
        dict.Add(4, "München");

        foreach(KeyValuePair<int, string> kvp in dict)
        {
            Console.WriteLine($"Die Nummer {kvp.Key} hat als Wert {kvp.Value}");
        }

        // Gibt es im Dictionary einen Key mit "1", wenn ja, dann hol mir den Wert davon raus
        if(dict.ContainsKey(1))
            Console.WriteLine(dict[1]);

        // Stack
        Stack<string> strings = new Stack<string>();
        strings.Push("Element 1"); //Element eintragen
        strings.Peek(); // oberstes Element ausgeben
        strings.Pop(); //oberste Element ausgeben + löschen

        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Element ABC"); //Element hinzufügen
        queue.Peek(); // älteste Element ausgeben was hinzugefügt wurde
        queue.Dequeue(); //älteste Element aus + löscht es
    }
}