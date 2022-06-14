using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    public class ToolClass
    {
        Dictionary<string, Kreds> KredsDict = new Dictionary<string, Kreds>();
        Dictionary<string, Badetidsperiode> btpDict = new Dictionary<string, Badetidsperiode>();
        public void Kredse()
        {


            KredsDict.Add("LYNGBY", new Kreds("LYNGBY", "LyngbyPool", "Lyngbyvej 69 Lyngby", 24));
            KredsDict.Add("KBH", new Kreds("KBH", "Tivoli", "Lyngbyvej 69 KBH", 24));
            KredsDict.Add("ROSKILDE", new Kreds("ROSKILDE", "Roskilde Badeland", "Lyngbyvej 69 Roskilde", 24));
            KredsDict.Add("NÆSTVED", new Kreds("NÆSTVED", "Bon Bon Land", "Lyngbyvej 69 Næstved", 24));
            KredsDict.Add("HOLBÆK", new Kreds("HOLBÆK", "Holbæk Pool", "Lyngbyvej 69 ,Holbæk", 24));

        }


        public void aktiviteter()
        {
            btpDict.Add("MORGENSVØM", new Badetidsperiode("MORGENSVØM", "Morgensvømning", DayOfWeek.Monday, 6, 30, 8, 45));
            btpDict.Add("AFTENSVØM", new Badetidsperiode("AFTENSVØM", "Aftensvømning", DayOfWeek.Monday, 18, 30, 20, 45));
            btpDict.Add("BADELAND", new Badetidsperiode("BADELAND", "Badeland", DayOfWeek.Tuesday, 10, 00, 18, 30));
            btpDict.Add("STRAND", new Badetidsperiode("STRAND", "Strandtur", DayOfWeek.Thursday, 8, 30, 12, 45));
        }
        public void AddKreds(string ID, string navn, string adresse, int antalDeltagere)
        {
            KredsDict.Add(ID, new Kreds(ID, navn, adresse, antalDeltagere));
        }

        public void AddAktivitet(string ID, string navn, DayOfWeek dag, int startHrs, int startMin, int slutHrs, int slutMin)
        {
            btpDict.Add(ID, new Badetidsperiode(ID, navn, dag, startHrs, startMin, slutHrs, slutMin));
        }
        public void SletKreds(string id)
        {
            KredsDict.Remove(id);
        }
        public void SletAktivitet(string id)
        {
            btpDict.Remove(id);
        }

        public void displayKredse()
        {
            foreach (KeyValuePair<string, Kreds> k in KredsDict)
            {
                Console.WriteLine(k);
            }
        }
        public void displayAktiviteter()
        {
            foreach (KeyValuePair<string, Badetidsperiode> b in btpDict)
            {
                Console.WriteLine(b);
            }
        }

        public void searchkreds(string ID)
        {
            Console.WriteLine(KredsDict[ID]);
        }

        public ToolClass()
        {
            Kredse();
            aktiviteter();
        }
    }
}
