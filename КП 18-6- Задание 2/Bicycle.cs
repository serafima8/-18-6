using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП_18_6__Задание_2
{
    //производный класс велосипед
    class Bicycle : Vehicle
    {
        /// <summary>
        /// поле кол-ва пассажиров
        /// </summary>
        private int passengers;
        /// <summary>
        /// свойства 
        /// </summary>
        public int Passengers { get { return passengers; } set { passengers = value; } }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Bicycle() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="maxS"></param>
        /// <param name="yearOfIssue"></param>
        /// <param name="pessengers"></param>
        public Bicycle(int price, int maxS, int yearOfIssue, int pessengers) : base( price, maxS, yearOfIssue)
        {
            this.Passengers = passengers;
        }
        /// <summary>
        /// метод для вывода информации о транспорте (переопределенный)
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Цена: {Price}\nМаксимальная скорость: {MaxS}\nГод выпуска: {YearOfIssue}\nКол-во пассажиров: {passengers}");
        }
    }
}
