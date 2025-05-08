namespace M009_Polymorphismus;


public class Program
{
    static void Main(string[] args)
    {
        // Polymorphismus
        // -> Typkompatibilität

        // Jeder Typ ist mit seiner Oberklasse kompatibel
        // ganz vorne = Basisklasse => Das geht
        Chef undercoverChef = new Mitarbeiter(30, "Max");
        undercoverChef.Bewegen(50);



        // Mitarbeiter kann nicht in ein Chef umgewandelt werden 
        // Abgeleitete Klasse = new Basisklasse() geht nicht
        //Mitarbeiter m = new Chef(30);

        // Basisklasse kann jegliche abgeleitete Klassenform annehmen
        // ABER: Keine Abgeleitete Klasse kann die Basisklasse annehmen

        //if(deutscheChef.GetType() == typeof(Mitarbeiter))
        //{
        //    Console.WriteLine("True");
        //}

        //if(deutscheChef.GetType() == typeof(Chef))
        //{
        //    Console.WriteLine("False");
        //}

        Console.WriteLine(undercoverChef.GetType()); // M009_Polymorphismus.Mitarbeiter
        Console.WriteLine(typeof(Chef)); // M009_Polymorphismus.Chef


        Chef OberBoss = new Chef(55);
        Mitarbeiter Sklave = new Mitarbeiter(18, "Felix");

        Console.WriteLine(Sklave.GetType());
        Console.WriteLine(OberBoss.GetType());

        if(Sklave is Mitarbeiter)
            Console.WriteLine("Sklave is Mitarbeiter");
        if(Sklave is Chef)
            Console.WriteLine("Sklave is Chef ");

        if (OberBoss is Mitarbeiter)
            Console.WriteLine("Oberboss ist Mitarbeiter");

        if(OberBoss is Chef)
            Console.WriteLine("Oberboss is Chef");

        if(Sklave.GetType() == typeof(Chef))
            Console.WriteLine("True");
       

        // is = Typabfrage oder Ableitungsabfrage = Ist Sklave abgeleitet von Chef => Ja
        // GetType() oder Typeof() = Typabfrage

        //Console.WriteLine(Sklave is Chef);
    }
}