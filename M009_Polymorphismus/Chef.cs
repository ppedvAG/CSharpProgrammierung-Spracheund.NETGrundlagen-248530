using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M009_Polymorphismus;

public class Chef
{
    public int Alter { get; set; }
    public Chef(int alter)
    {
        Alter = alter;
    }
    public virtual void Bewegen(int distanz)
    {
        Console.WriteLine($"Chef bewegt sich um {distanz}m");
    }
}
