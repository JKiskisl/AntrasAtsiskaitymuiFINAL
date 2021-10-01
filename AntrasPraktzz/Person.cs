using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntrasPraktzz
{
    class Person
    {
        public string Name;
        public string LastName;
        public int Year;
        public int Month;
        public int Day;

        public DateTime Now = DateTime.Now;

        public Person(string n, string ln, int y, int m, int d)
        {
            Name = n;
            LastName = ln;
            Year = y;
            Month = m;
            Day = d;

        }
        public int Age()
        {
            DateTime Bday = new DateTime(Year, Month, Day);
            return (int)((Now - Bday).TotalDays / 365.25);
        }
        public int Bday()
        {
            DateTime TillBday = new DateTime(Now.Year, Month, Day);
            if ((int)(TillBday - Now).TotalDays < 0)
            {
                return (int)((TillBday - Now).TotalDays + 365.25);
            }
            else
            {
                return (int)((TillBday - Now).TotalDays);
            }
        }
        public string Info()
        {
            return "Name: " + Name + "\n" + "Last Name: " + LastName + "\n" + "Age: " + Age() + "\n" + "Till bday: " + Bday();
        }
    }
}
