using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        class Car
        {
            public string Name;
            public string Marka;
            public string Magaz;
            public string Tup;
            public double YearIncome;
            public string Privod;
            public bool Strahovka;

            public double GetYearIncomePerInhabitant()
            {
                return YearIncome;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введiть назву автомобiля: "); string sName = Console.ReadLine();
            Console.Write("Введiть марку автомобiля: "); string sMarka = Console.ReadLine();
            Console.Write("Введiть назву магазину: "); string sMagaz = Console.ReadLine();
            Console.Write("Введiть тип автомобыля: "); string sTup = Console.ReadLine();       
            Console.Write("Введiть цiну автомобiля: "); string sYearIncome = Console.ReadLine();
            Console.Write("Введiть привод автомобiля: "); string sPrivod = Console.ReadLine();
            Console.Write("Чи є у автомобiля страховка? (y-так, n-нi): "); ConsoleKeyInfo keyStrahovka = Console.ReadKey(); Console.WriteLine();

            Car OurCar = new Car();

            OurCar.Name = sName;
            OurCar.Marka = sMarka;
            OurCar.Magaz = sMagaz;
            OurCar.Tup = sTup;
            OurCar.YearIncome = double.Parse(sYearIncome);
            OurCar.Privod = sPrivod;
            OurCar.Strahovka = keyStrahovka.Key == ConsoleKey.Y ? true : false;
            

            double YearIncomePerInhabitant = OurCar.GetYearIncomePerInhabitant();

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Данi про об`ект: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Назва автомобiля: " + OurCar.Name);
            Console.WriteLine("Марка автомобiля: " + OurCar.Marka);
            Console.WriteLine("Назва магазину: " + OurCar.Magaz);
            Console.WriteLine("Тип автомобыля: " + OurCar.Tup);
            Console.WriteLine("Цiна автомобiля: " + OurCar.YearIncome.ToString("0.00"));
            Console.WriteLine("Привод автомобiля: " + OurCar.Privod);
            Console.WriteLine(OurCar.Strahovka ? "У автомобiля є страховка" : "У автомобiля немає страховка");

            Console.ReadKey();
        }
    }
}
