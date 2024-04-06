using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП_18_6__Задание_2
{
    //производный класс грузовик
    class Lorry : Vehicle
    {
      
        /// <summary>
        /// Свойство Емкость
        /// </summary>
        public int MaxCapacity { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Lorry() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="maxS"></param>
        /// <param name="yearOfIssue"></param>
        /// <param name="maxCapacity"></param>
        public Lorry( int price, int maxS, int yearOfIssue, int maxCapacity) : base( price, maxS, yearOfIssue)
        {
            this.MaxCapacity = maxCapacity;
        }
        /// <summary>
        /// метод для вывода информации о транспорте (переопределенный)
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Цена: {Price}\nМаксимальная скорость: {MaxS}\nГод выпуска: {YearOfIssue}\nЕмкость: {MaxCapacity}");
        }
    }
}
