//Objekte erstellen u. ausgeben
using System.Runtime.ExceptionServices;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        //Objekte,Attacken
        Attacke Attacke1 = new Attacke("Eisrune", -4, -2);
        Attacke Attacke2 = new Attacke("Funkenschlag", -2, -1);
        Attacke Attacke3 = new Attacke("Blitz", -6, -3);
        Attacke Attacke4 = new Attacke("Schwerthieb", -4, -2);
        Attacke Attacke5 = new Attacke("Schildstoß", -2, -1);
        Attacke Attacke6 = new Attacke("Stoß Sprint", -6, -3);
        Attacke Attacke7 = new Attacke("Giftiger Pfeil", -4, -2);
        Attacke Attacke8 = new Attacke("Pfeilschuss", -2, -1);
        Attacke Attacke9 = new Attacke("Wirbelwindsprint", -6, -3);
    }
}
//KLASSEN ERSTELLEN
class Klasse
{
    //Eigenschaften
    public static int HP { get; set; }
    public static int SP { get; set; }
    public string Name { get; set; }
    public string Beschreibung { get; set; }
    //Methoden
    //Konstruktor
}
class Person
{
    //Eigenschaften
    public string Vorname { get; set; }
    public string Nachname { get; set; }
    public int Alter { get; set; }
    //Methoden
    //Konstruktor
    public Person(string _Vorname, string _Nachname, int _Alter)
    {
        Vorname = _Vorname;
        Nachname = _Nachname;
        Alter = _Alter;
    }
}

class Knight : Klasse
{
    public void knight()
    {
        HP = 70;
        SP = 30;
        Name = "Ritter";
        Beschreibung = "Robust und edel";
    }
}

class Mage : Klasse
{
    public void mage()
    {
        HP = 30;
        SP = 70;
        Name = "Magier";
        Beschreibung = "Weise und Gebildet";
    }
}

class Archer : Klasse
{
    public void archer()
    {
        HP = 50;
        SP = 50;
        Name = "Bogenschütze";
        Beschreibung = "Ausgweogen und agil";
    }
}

class Attacke
{
    //Eigenschaften
    public string AttackenName { get; set; }
    public int BasisSchaden { get; set; }
    public int SpVerbrauch { get; set; }
    //Methoden
    //Konstruktor
    public Attacke(string _Attackenname, int _Basisschaden, int _SpVerbrauch)
    {
        AttackenName = _Attackenname;
        BasisSchaden = _Basisschaden;
        SpVerbrauch = _SpVerbrauch;
    }
}

class Eniemy : Klasse
{
    public int EniemyDMG { get; set; }
}
