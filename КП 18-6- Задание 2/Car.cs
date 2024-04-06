using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП_18_6__Задание_2
{
    //производный класс автомобиль
    class Car : Vehicle
    {

        /// <summary>
        /// Свойство Мощность автомобиля
        /// </summary>
        public int Power { get; set; }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Car() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="maxS"></param>
        /// <param name="yearOfIssue"></param>
        /// <param name="power"></param>
        public Car( int price, int maxS, int yearOfIssue, int power) : base(price, maxS, yearOfIssue)
        {
            this.Power = power;
        }
        /// <summary>
        /// метод для вывода информации о транспорте (переопределенный)
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Цена: {Price}\nМаксимальная скорость: {MaxS}\nГод выпуска: {YearOfIssue}\nМощность автомобиля: {Power}");
        }
    }
}
