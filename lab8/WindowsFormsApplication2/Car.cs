using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Car
    {
        public string Name;
        public string Marka;
        public string Magaz;
        public double Age;
        public double YearIncome;
        public bool Strahovka;
        public bool Credit;
        public double CreditN;

        public string GetPrice()
        {
            if (Credit)
            {
                double a = YearIncome / CreditN + YearIncome * 0.01;
                return string.Format("{0}", a);
            }
            else {
                return string.Format(""); ;
            }
        }
    }
}
