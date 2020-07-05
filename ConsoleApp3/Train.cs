using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    partial class Train
    {
        private string description;
        public string Description { get { return description; } set { description = value; } }

        private string manufactured;
        public string Manufactured { get { return manufactured; } set { manufactured = value; } }

        private string countyOfUsing;
        public string CountryOfUsing { get { return countyOfUsing; } set { countyOfUsing = value; } }

        private int valueOfUnits;
        public int ValueOfUnits { get { return valueOfUnits; } set { valueOfUnits = value; } }

        private int constructionSpeed;
        public int ConstructionSpeed { get { return constructionSpeed; } set { constructionSpeed = value; } }

        private bool isElectric;
        public bool IsElectric { get { return isElectric; } set { isElectric = value; } }


        public static string CompanyUser { get; set; }
        public static int Mashinists { get; set; }

        public Train()
        {
            Description = "Локомотив по умолчанию";
            Manufactured = "производитель неизвестен";
            CountryOfUsing = "страна эксплуатации неизвестна";
            ValueOfUnits = 0;
            ConstructionSpeed = 0;
            IsElectric = false;
        }

        public Train(string desc, string manuf, string country, int val_of_units, int speed, bool is_electric)
        {
            Description = desc;
            Manufactured = manuf;
            CountryOfUsing = country;
            ValueOfUnits = val_of_units;
            ConstructionSpeed = speed;
            IsElectric = is_electric;
        }

        public Train(string desc, string manuf, string country)
        {
            Description = desc;
            Manufactured = manuf;
            CountryOfUsing = country;
            ValueOfUnits = 0;
            ConstructionSpeed = 0;
            IsElectric = true;
        }

        static Train()
        {
            CompanyUser = "РЖД";
            Mashinists = 2;
        }

        public string Welcome() { return Description + " прибывает!\n"; }
        public string LetsGo() { return Description + " отправляется!\n\n\n"; }
    }
}
