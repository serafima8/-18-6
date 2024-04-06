using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП_18_6__Задание_2
{
    class Garage
    {
        /// <summary>
        /// Метод для ввода информации о велосипеде
        /// </summary>
        /// <returns></returns>
        static public Bicycle AddBicycle()
        {
            try
            {
                Console.Write("Введите цену: ");
                int price = int.Parse(Console.ReadLine());
                Console.Write("Введите максимальная скорость: ");
                int maxS = int.Parse(Console.ReadLine());
                Console.Write("Введите год выпуска: ");
                int yearOfIssue = int.Parse(Console.ReadLine());
                Console.Write("Введите кол-во пассажиров: ");
                int pasengers = int.Parse(Console.ReadLine());
                return new Bicycle(price, maxS, yearOfIssue, pasengers);
            }
            catch
            {
                return AddBicycle();
            }
        }
        /// <summary>
        /// Метод для ввода информации об автомобиле
        /// </summary>
        /// <returns></returns>
        static public Car AddCar()
        {
            try
            {
                Console.Write("Введите цену: ");
                int price = int.Parse(Console.ReadLine());
                Console.Write("Введите максимальная скорость: ");
                int maxS = int.Parse(Console.ReadLine());
                Console.Write("Введите год выпуска: ");
                int yearOfIssue = int.Parse(Console.ReadLine());
                Console.Write("Введите мощность автомобиля: ");
                int power = int.Parse(Console.ReadLine());
                return new Car( price, maxS, yearOfIssue, power);
            }
            catch
            {
                return AddCar();
            }
        }
        /// <summary>
        /// Метод для ввода информаци о грузовике
        /// </summary>
        /// <returns></returns>
        static public Lorry AddLorry()
        {
            try
            {
                Console.Write("Введите цену: ");
                int price = int.Parse(Console.ReadLine());
                Console.Write("Введите максимальная скорость: ");
                int maxS = int.Parse(Console.ReadLine());
                Console.Write("Введите год выпуска: ");
                int yearOfIssue = int.Parse(Console.ReadLine());
                Console.Write("Максимальна емкость: ");
                int maxCapacity = int.Parse(Console.ReadLine());
                return new Lorry( price, maxS, yearOfIssue, maxCapacity);
            }
            catch
            {
                return AddLorry();
            }
        }
    }
}
