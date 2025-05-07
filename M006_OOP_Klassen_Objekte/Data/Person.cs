using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M006_OOP_Klassen_Objekte.Data
{
    public class Person
    {
        #region Feld

        // Feld
        // Feld ist einfach nur ein Variablen Wert
        // Felder sollten nur indirekt angegriffen werden, sprich in der Klasse nur
        // Durch den private Modifier kann das Feld nicht von außerhalb der Klasse zugegriffen werden

        private string Vorname;

        // Die Get-Methode wird verwendet, um den Wert aus diesem Feld auslesen
        public string GetVorname()
        {
            return Vorname;
        }

        // Die Set-Methode wird verwendet, um neue Werte in das Feld einzutragen
        // this.Vorname bezieht sich auf das Feld in Z.18 (oben zu sehen)
        // Vorname bezieht sich auf den Parameter innerhalb der Methode
        public void SetVorname(string Vorname)
        {
            this.Vorname = Vorname;
        }


        #endregion

        #region Eigenschaften

        // Eigenschaften (Property)
        // Vereinfachung von dem alten Get-/Setmethoden Schema

        public string Nachname { get; set; }

        // Full Property
        //public int Alter
        //{
        //    get
        //    {
        //        return Alter;
        //    }

        //    set 
        //    { 
        //        Alter = value;
        //    }
        //}
        public int Alter {  get; set; }

        #endregion

        #region Konstruktor

        // Konstruktor
        // Wird beim Erstellen eines Objekt ausgeführt
        // Der Standardkonstruktor existiert immer, wenn kein anderer Konstruktor definiert ist

        public Person()
        {
            Console.WriteLine("Person erstellt");
        }

        public Person(string vorname, string nachname) : this()  // this()
        {
            this.Vorname = vorname;
            this.Nachname = nachname;
        }

        public Person(string vorname, string nachname, int alter) : this(vorname, nachname)
        {
            Alter = alter;
        }



        #endregion
    }
}
