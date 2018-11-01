using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace lab14
{
    class Program
    {
        static List<Car> cars;
        static void PrintCars() { 
            foreach (Car car in cars) { 
                Console.WriteLine(car.Info().Replace('і', 'i')); 
            }
            Console.WriteLine(); 
        }
        static void Main(string[] args)
        {
           cars = new List<Car>();
           FileStream fs = new FileStream("cars.towns", FileMode.Open); 
            BinaryReader reader = new BinaryReader(fs); 
            try {     
                Car car;     
                Console.WriteLine("Читаємо данi з файлу...\n");     
                while (reader.BaseStream.Position < reader.BaseStream.Length){         
                    car = new Car();         
                    for (int i = 1; i <= 8; i++){             
                        switch (i){
                            case 1:
                                car.Name = reader.ReadString();
                                break;
                            case 2:
                                car.Marka = reader.ReadString();
                                break;
                            case 3:
                                car.Magaz = reader.ReadString();
                                break;
                            case 4:
                                car.Age = reader.ReadDouble();
                                break;
                            case 5:
                                car.YearIncome = reader.ReadDouble();
                                break;
                            case 6:
                                car.Strahovka = reader.ReadBoolean();
                                break;
                            case 7:
                                car.Credit = reader.ReadBoolean();
                                break;
                            case 8:
                                car.CreditN = reader.ReadDouble();
                                break; 
                        }         
                    }         
                    cars.Add(car);     
                } 
            } catch (Exception ex) {     
                Console.WriteLine("Сталась помилка: {0}", ex.Message); 
            } finally {     
                reader.Close(); 
            } 
            Console.WriteLine("Несортований перелiк автомобілів: {0}", cars.Count);
            PrintCars(); 
            cars.Sort();
            Console.WriteLine("Сортований перелiк автомобілів: {0}", cars.Count);
            PrintCars();
            Console.WriteLine("Додаємо новий запис: Scoda"); 
            Car townOdesa = new Car("Scoda", "Scoda", "Scoda", 5, 200000, true, false, 0);
            cars.Add(townOdesa); 
            cars.Sort(); 
            Console.WriteLine("Перелiк мiст: {0}", cars.Count);
            PrintCars(); 
            Console.WriteLine("Видаляємо останнє значення");
            cars.RemoveAt(cars.Count - 1);
            Console.WriteLine("Перелiк мiст: {0}", cars.Count);

            PrintCars(); 
            Console.ReadKey();  
        }
    }
}
