namespace CMDTest;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Anzahl der Argumente: " + args.Length);
        foreach (string arg in args)
        {
            Console.WriteLine("Argument: " + arg);
        }
    }
}