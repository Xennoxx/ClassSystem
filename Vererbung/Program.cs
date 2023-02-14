//Objekte erstellen u. ausgeben
using System.Runtime.ExceptionServices;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
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
class Person
{
    //Eigenschaften
    public string Vorname { get; set; }
    public string Nachname { get; set; }
    public int Alter { get; set; }
    //Methoden
    //Konstruktor
    public Person (string _Vorname, string _Nachname, int _Alter)
    {
        Vorname = _Vorname;
        Nachname = _Nachname;
        Alter = _Alter;
    }
}
class Klasse
{
    //Eigenschaften
    public static int HP { get; set; }
    public static int SP { get; set; }
    public string KlassenName { get; set; }
    public string Klassenbeschreibung { get; set; }
    //Methoden
    //Konstruktor
}

class Knight : Klasse
{
    public void knight()
    {
        HP = 70;
        SP = 30;
        KlassenName = "Ritter";
        Klassenbeschreibung = "Robust und edel";
    }
}

class Mage : Klasse
{
    public void mage()
    {
        HP = 30;
        SP = 70;
        KlassenName = "Magier";
        Klassenbeschreibung = "Weise und Gebildet";
    }
}

class Archer : Klasse
{
    public void archer()
    {
        HP = 50;
        SP = 50;
        KlassenName = "Bogenschütze";
        Klassenbeschreibung = "Ausgweogen und agil";
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

class Eniemy
{
    public int EniemyTP { get; set; }
    public int EniemyHP { get; set; }
    public int EniemyDMG { get; set; }
}

/*//Mensch/Objekt/Instanz
Person person1 = new Person("Nikki","Hühn",19);
//Magier/Objekt/Instanz
Klasse Magier = new Klasse(30, 70);
Magier.KlassenName = "Magier";
Magier.Klassenbeschreibung = "Er weiß, wie man Gegner verzaubert";
Attacke Attacke1 = new Attacke("Eisrune", -4, -2);
Attacke Attacke2 = new Attacke("Funkenschlag", -2, -1);
Attacke Attacke3 = new Attacke("Blitz", -6, -3);
//Ritter/Objekt/Instanz
Klasse Ritter = new Klasse(70, 30);
Ritter.KlassenName = "Ritter";
Ritter.Klassenbeschreibung = "Er ist standhaft und mutig.";
Attacke Attacke4 = new Attacke("Schwerthieb", -4, -2);
Attacke Attacke5 = new Attacke("Schildstoß", -2, -1);
Attacke Attacke6 = new Attacke("Stoß Sprint", -6, -3);
//Archer/Objekt/Instanz
Klasse Archer = new Klasse(50, 50);
Archer.KlassenName = "Archer";
Archer.Klassenbeschreibung = "Er ist ruhig, gelassen und ausgeglichen.";
Attacke Attacke7 = new Attacke("Giftiger Pfeil", -4, -2);
//Attacke Attacke8 = new Attacke("Pfeilschuss", -2, -1);
//Attacke Attacke9 = new Attacke("Wirbelwindsprint", -6, -3);
//Dieb(Benjamin)Sprint*/