namespace M013_Exception;

/// Fehlerbehandlung
/// try-catch
/// Wird verwendet um Exceptions (Fehler => Abstürze verhindern)
/// Hintergrund: Plattformunabhängigkeit
/// Wenn eine Exception auftritt, kann der Benutzer des Codes selbst entscheiden, wie diese Exception zu behandeln ist


public class Program
{
    static void Main(string[] args)
    {
        try
        {
            string eingabe = Console.ReadLine();
            int x = int.Parse(eingabe);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Die Eingabe ist keine Zahl");
            Console.WriteLine(ex.Message); // Die interne C# Fehlermeldung
            Console.WriteLine(ex.StackTrace); // Rückverfolgung wo der Fehler war
        }
        catch (OverflowException e)
        {
            Console.WriteLine("Die Eingabe ist zu klein/groß");
            Console.WriteLine(e.Message); // Die interne C# Fehlermeldung
            Console.WriteLine(e.StackTrace); // Rückverfolgung wo der Fehler war
        }
        catch (Exception)
        {
            Console.WriteLine("Anderer Fehler");
        }
        finally
        {
            Console.WriteLine("Parsen fertig");
        }
    }
}
