using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП_18_6__Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bicycle> Bicycles = new List<Bicycle>();
            List<Car> Car = new List<Car>();
            List<Lorry> Lorry = new List<Lorry>();
            List<Vehicle> vehicles = new List<Vehicle>();

            bool flag = true;
            while (flag)
            {
                    Console.WriteLine("Выбери нужное Вам действие:\n 1.Добавить в список велосипед;\n 2.Добавить в список машину;\n 3.Добавить в список грузовик;\n 4.Вывести все велосипеды из списка;\n 5.Вывести все машины из списка;\n 6.Вывести все грузовики из списка;\n 7.Выход.");
                    int action = int.Parse(Console.ReadLine());
                    switch (action)
                    {
                        case 1:
                            Bicycle bicycle = new Bicycle(); 
                            vehicles.Add(Garage.AddBicycle()); 
                            Console.Clear(); 
                            break;
                        case 2: 
                            Car car = new Car();
                            vehicles.Add(Garage.AddCar()); 
                            Console.Clear();
                            break;
                        case 3:
                            Lorry lorry = new Lorry(); 
                            vehicles.Add(Garage.AddLorry());
                            Console.Clear(); 
                            break;
                        case 4:
                            Console.WriteLine("Велосипеды:");
                            foreach (var elem in vehicles) 
                            {
                               elem.Print();
                            }
                            break;
                        case 5:
                            Console.WriteLine("Машины:");
                            foreach (var elem in Car)
                            {
                                elem.Print();
                            } 
                            break;
                        case 6: 
                            Console.WriteLine("Грузовики:"); 
                            foreach (var elem in Lorry)
                            { 
                                elem.Print(); 
                            } 
                            break;
                        case 7: 
                            flag = false; break;
                        default: Console.WriteLine("Действия не существует");
                            break;

                    }
                Console.ReadKey();
            }
        }
    }
}
