using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    internal class class_Person
    {
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
    }
}
