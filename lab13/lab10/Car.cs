using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    public class Car {     
        public string Name { get; set; }
        public string Marka { get; set; }
        public string Magaz { get; set; }
        public double Age { get; set; }
        public double YearIncome { get; set; }
        public bool Strahovka { get; set; }
        public bool Credit { get; set; }
        public double CreditN { get; set; }

        public double GetPrice()
        {
            if (Credit)
            {
                double a = YearIncome / CreditN + YearIncome * 0.01;
                return a;
            }
            else
            {
                return 0;
            }
        }
 
    public Car(){ 
 
    }

    public Car(string name, string marka, string magaz, double age, double yearIncome, bool strahovka,  bool credit, double creditN) { 
        Name = name;
        Marka = marka;
        Magaz = magaz;
        Age = age;
        YearIncome = yearIncome;
        Strahovka = strahovka;
        Credit = credit;
        CreditN = creditN;
    }
    }
}
