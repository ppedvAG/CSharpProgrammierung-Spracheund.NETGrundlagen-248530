using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    - Schulungsort
    - Trainer
    - Teilnehmer
    - Ausstattung
    - Dauer
    - Titel
    - Location
*/
namespace M006_OOP_Klassen_Objekte.Data
{
    public class Schulung
    {
        public Person Trainer { get; set; }
        public Person[] Teilnehmer { get; set; }
        public string Standort { get; set; }
        public Schulungstyp Typ { get; set; }
        public int Dauer {  get; set; }
        public string Titel { get; set; }

        // Strg + Punkt auf den Klassennamen -> Generate Constructor
        public Schulung(Person trainer,string standort, Schulungstyp typ, int dauer, string titel,params Person[] teilnehmer)
        {
            Trainer = trainer;
            Teilnehmer = teilnehmer;
            Standort = standort;
            Typ = typ;
            Dauer = dauer;
            Titel = titel;
        }

        public void NeueTeilnehmerHinzufuegen(params Person[] teilnehmer)
        {
            Teilnehmer = Teilnehmer.Concat(teilnehmer).ToArray();
        }
    }
}
