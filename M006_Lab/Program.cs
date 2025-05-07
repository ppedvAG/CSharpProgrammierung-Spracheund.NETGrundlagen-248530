namespace Fahrzeugpark
{
    public class Fahrzeug
    {
        // Eigenschaften
        public string Name { get; set; }
        public int MaxGeschwindigkeit { get; set; }
        public int AktGeschwindigkeit { get; set; }
        public double Preis {  get; set; }
        public bool MotorLaeuft {  get; set; }

        // Konstruktor
        public Fahrzeug(string name, int maxG, double preis)
        {
            this.Name = name;
            this.MaxGeschwindigkeit = maxG;
            this.Preis = preis;
            this.AktGeschwindigkeit = 0;
            this.MotorLaeuft = false;
        }

        // Info
        public string Info()
        {
            if (this.MotorLaeuft)
                return $"{this.Name} kostet {this.Preis}€ und fährt momentan mit {this.AktGeschwindigkeit} von maximal {this.MaxGeschwindigkeit}";
            else 
                return $"{this.Name} kostet {this.Preis}€und könnte maximal {this.MaxGeschwindigkeit}km/h fahren.";
        }

        // StarteMotor
        public void StarteMotor()
        {
            if(this.MotorLaeuft)
                Console.WriteLine($"Der Motor von {this.Name} läuft bereits");
            else
            {
                this.MotorLaeuft = true;
                Console.WriteLine($"Der Motor von {this.Name} wurde gestartet");
            }
        }

        // StoppeMotor
        public void StoppeMotor()
        {
            if(!this.MotorLaeuft)
                Console.WriteLine($"Der Motor von {this.Name} ist bereits gestoppt");
            else if (this.AktGeschwindigkeit > 0)
                Console.WriteLine($"Der Motor kann nicht gestoppt werden, da sich {this.Name} noch bewegt");
            else
            {
                this.MotorLaeuft = false;
                Console.WriteLine($"Der Motor von {this.Name} wurde gestoppt");
            }
        }

        // Beschleunigen
        public void Beschleunigen(int a)
        {
            if(this.MotorLaeuft)
            {
                if (this.AktGeschwindigkeit + a > this.MaxGeschwindigkeit)
                    this.AktGeschwindigkeit = this.MaxGeschwindigkeit;
                else if (this.AktGeschwindigkeit + a < 0)
                    this.AktGeschwindigkeit = 0;
                else 
                    this.AktGeschwindigkeit += a;
                Console.WriteLine($"{this.Name} bewegt sich jetzt mit {this.AktGeschwindigkeit}km/h");
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Ändern des durch Console verwendetetn Zeichensatzes auf Unicode (damit das €-Symbol angezeigt werde kann)
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Fahrzeug fz1 = new Fahrzeug("BMW", 300, 10000);
            Console.WriteLine(fz1.Info() + "\n");

            // Methodenausführungen
            fz1.StarteMotor();
            fz1.Beschleunigen(120);
            Console.WriteLine(fz1.Info() + "\n");

            fz1.Beschleunigen(300);
            Console.WriteLine(fz1.Info() + "\n");

            fz1.Beschleunigen(-500);
            fz1.StoppeMotor();
            Console.WriteLine(fz1.Info() + "\n");

        }
    }
}