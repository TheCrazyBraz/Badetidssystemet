using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{

    public class Badetidsperiode
    {
        string _ID;
        string _aktivitet;
        DayOfWeek _Dag;
        DateTime _StartTidspunkt;
        DateTime _SlutTidspunkt;
        public Badetidsperiode(string ID, string aktivitet, DayOfWeek Dag, int StartHrs, int StartMin, int SlutHrs, int SlutMin)
        {
            _ID = ID;
            _aktivitet = aktivitet;
            _Dag = Dag;
            DateTime StartTidspunkt = new DateTime(2022, 8, 25, StartHrs, StartMin, 0);
            DateTime SlutTidspunkt = new DateTime(2022, 8, 25, SlutHrs, SlutMin, 0);
            _StartTidspunkt = StartTidspunkt;
            _SlutTidspunkt = SlutTidspunkt;
        }





        public override string ToString()
        {
            return "Aktivitetens Navn: " + _aktivitet.ToString() + " Dag: " + _Dag.ToString() + " Starter: " + _StartTidspunkt.TimeOfDay.ToString() + " Slutter: " + _SlutTidspunkt.TimeOfDay.ToString();
        }
    }
}
