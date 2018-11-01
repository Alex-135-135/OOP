using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        public class Car
        {
            public string Name;
            public string Marka;
            public string Magaz;
            public string Tup;
            public double Price;
            public string Privod;
            public bool Strahovka;

            public double yearIncomePerInhabitant { get { return GetYearIncomePerInhabitant(); } }
            public double GetYearIncomePerInhabitant() { return Price; }
        }

        static void Main(string[] args)
        {
           Car[] arrCar;

            Console.Write("Введiть кiлькiсть автомобiлiв: ");
            int cntCar = int.Parse(Console.ReadLine());
            arrCar = new Car[cntCar];

            for (int i = 0; i < cntCar; i++)
            {
                Console.Write("Введiть назву автомобiля: "); string sName = Console.ReadLine();
                Console.Write("Введiть марку автомобiля: "); string sMarka = Console.ReadLine();
                Console.Write("Введiть назву магазину: "); string sMagaz = Console.ReadLine();
                Console.Write("Введiть тип автомобыля: "); string sTup = Console.ReadLine();
                Console.Write("Введiть цiну автомобiля: "); string sPrice = Console.ReadLine();
                Console.Write("Введiть привод автомобiля: "); string sPrivod = Console.ReadLine();
                Console.Write("Чи є у автомобiля страховка? (y-так, n-нi): "); ConsoleKeyInfo keyStrahovka = Console.ReadKey();
                Console.WriteLine();

                Car OurCar = new Car();
                OurCar.Name = sName;
                OurCar.Marka = sMarka;
                OurCar.Magaz = sMagaz;
                OurCar.Tup = sTup;
                OurCar.Price = double.Parse(sPrice);
                OurCar.Privod = sPrivod;
                OurCar.Strahovka = keyStrahovka.Key == ConsoleKey.Y ? true : false;

                arrCar[i] = OurCar;
            }
            foreach (Car t in arrCar) {
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Данi про автомобiль {0}", t.Name);
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Марка автомобiля: " + t.Marka);
                Console.WriteLine("Назва магазину: " + t.Magaz);
                Console.WriteLine("Тип автомобыля: " + t.Tup);
                Console.WriteLine("Цiна автомобiля: " + t.Price.ToString("0.00"));
                Console.WriteLine("Привод автомобiля: " + t.Privod);
                Console.WriteLine(t.Strahovka ? "У автомобiля є страховка" : "У автомобiля немає страховка");
            }

            Console.ReadKey();
        } 
        

    }
}
