//using Newtonsoft.Json;

using Newtonsoft.Json;
using System.Text.Json;
using System.Xml.Serialization;

namespace M014_Dateien;

public class Program
{
    static void Main(string[] args)
    {
        // Ordner erstellen, und in dieser Datei "Hallo Welt" Schreiben
        string folderPath = "Test";
        if(!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        // 2. Pfad zur Datei + Datei erstellen
        string filePath = Path.Combine(folderPath, "Test.txt");
        File.WriteAllText(filePath, "Hallo Welt");

        // StreamWriter
        // Byte für Byte Daten schreiben/lesen
        StreamWriter writer = new StreamWriter(filePath);
        writer.WriteLine("Hallo");
        writer.WriteLine("Welt");

        // Streams sogenannte Buffer
        // Flush() schreibt den Buffer in das File
        // Close() den Zugriff auf die Datei gewähren (Ich kann dann erst das sehen was drinnen steht)
        writer.Flush();
        writer.Close();

        // StreamReader
        // Die Datei auslesen
        StreamReader sr = new StreamReader(filePath);
        List<string> zeilen = new List<string>();

        // Datei auslesen => In Liste SPEICHERN!
        while (!sr.EndOfStream)
        {
            zeilen.Add(sr.ReadLine());
        }

        //// Datei beim auslesen geöffnet, wenn fertig ausgelesen, Datei schließen
        sr.Close();

        // using
        // AM Ende des Anweisungsblock der Stream geschlossen wird (heißt kein Close() nötig)
        // using sorgt dafür das wir kein Close() mehr brauchen, weil das sich nach dem Anweisungsblock schließt
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            sw.WriteLine("Hallo2");
            sw.WriteLine("Welt2");
        }

        //StreamWriter test = new StreamWriter(filePath);
        //test.WriteLine("Hallo soll drangehängt sein");
        //test.WriteLine("Welt soll drangehängt sein");

        //test.Flush();
        //test.Close();



        // JSON & XML 
        // Serialisierungsformate um Objekte aus dem Program zu bewegen (speichern, senden, ...)
        // Wird zwischen mehrere Geräte/Anwendungen verwendet, damit diese kommunizieren können

        // JSON
        // In C# gibt es 2 große JSON Frameworks
        // System.Text.JSON (intern)
        // Newtonsoft.JSON (extern)

        List<Fahrzeug> fahrzeuge = new List<Fahrzeug>()
        {
            new Fahrzeug(250, FahrzeugMarke.BMW),
            new Fahrzeug(175, FahrzeugMarke.VW),
            new Fahrzeug(195, FahrzeugMarke.BMW),
            new Fahrzeug(162, FahrzeugMarke.BMW),
            new Fahrzeug(186, FahrzeugMarke.Audi),
            new Fahrzeug(284, FahrzeugMarke.VW),
            new Fahrzeug(301, FahrzeugMarke.VW),
            new Fahrzeug(174, FahrzeugMarke.Audi),
        };

        // Pfad öffnen, datei erstellen
        string jsonPath = Path.Combine(folderPath, "Test.json");

        // Alt + Enter => "Newtonsoft.JSON Paket installieren" => bindet auch automatisch das using mit ein
        JsonSerializerSettings options = new JsonSerializerSettings(); // Optionen setzen, beim schreiben/lesen
        options.Formatting = Newtonsoft.Json.Formatting.Indented; // Schreibe mir das als JSON format in die Datei

        // Schreibe mir die FahrzeugListe mit den Optionen in das JSON mit dem JSON-Path
        string json = JsonConvert.SerializeObject(fahrzeuge, options); // Wichtig: Wir müssen die Optionen mitgeben
        File.WriteAllText(jsonPath, json);

        string readJson = File.ReadAllText(jsonPath);
        Fahrzeug[] readFzg = JsonConvert.DeserializeObject<Fahrzeug[]>(readJson);

        // Xml 
        string xmlPath = Path.Combine(folderPath, "Test.xml");

        XmlSerializer xml = new XmlSerializer(fahrzeuge.GetType());

        // Schreiben
        using(StreamWriter xmlWriter = new StreamWriter(xmlPath))
        {
            xml.Serialize(xmlWriter, fahrzeuge);
        }

        // Lesen
        using(StreamReader xmlReader = new StreamReader(xmlPath))
        {
            List<Fahrzeug> readFzhXML = xml.Deserialize<List<Fahrzeug>>(xmlReader);
        }

       
    }
}

public class Fahrzeug
{
    public int MaxV { get; set; }
    public FahrzeugMarke Marke { get; set; }
    public Fahrzeug(int maxV, FahrzeugMarke marke)
    {
        MaxV = maxV;
        Marke = marke;
    }
    public Fahrzeug() { }
}

public enum FahrzeugMarke
{
    Audi, BMW, VW
}

public static class XmlExtensions
{
    public static T Deserialize<T>(this XmlSerializer xml, TextReader s)
    {
        return (T)xml.Deserialize(s);
    }
}