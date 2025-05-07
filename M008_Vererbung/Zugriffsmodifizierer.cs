namespace M008_Vererbung;

public class Zugriffsmodifizerer
{
    public string Vorname { get; set; } // Public: Kann von überall angegriffen werden

    private string Nachname { get; set; } // private: Kann nur innerhalb der Klasse verwendet werden
    internal int Alter { get; set; } // internal: Kann von überall angegriffen werden, aber nur innerhalb vom Projekt

    ///////////////////////////////////////////////////

    protected double Groesse { get; set; } // protected: Wie private, aber auch in Unterklassen
    protected private int Gehalt { get; set; } // protected private: Wie private, aber auch in Unterklassen, ABER nur innerhalb des Projekt
    protected internal string Adresse { get; set; } // protected internal: Wie internal, aber auch in Unterklassen außerhalb vom Projekt

}