using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    public class Kreds
    {
        string _ID;
        string _Navn;
        string _Adresse;
        int _AntalDeltagere;
        public Kreds(string ID ="NULL", string Navn = "NULL", string Adresse = "NULL", int AntalDeltagere = 0)
        {
            _ID = ID;
            _Navn = Navn;
            _Adresse = Adresse;
            _AntalDeltagere = AntalDeltagere;
        }

        public override string ToString()
        {
            return "Kreds Navn: " + _Navn.ToString() + " Med ID: " + _ID.ToString() + " På adressen: " + _Adresse.ToString() + " - Gæster der ankommer: " + _AntalDeltagere.ToString();
        }
    }
}
