using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M009_Polymorphismus;

public class Mitarbeiter : Chef
{
    public string Name { get; set; }
    
    public Mitarbeiter(int alter, string name) : base(alter)
    {
        Name = name;
    }

    public override void Bewegen(int distanz)
    {
        Console.WriteLine($"{Name} bewegt sich um {distanz}m");
    }
}
