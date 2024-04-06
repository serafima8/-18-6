using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП_18_6__Задание_2
{
    //абстрактный класс Vehicle (транспортное средство).
    abstract class Vehicle
    {
      
        public int Price { get; set; }
        /// <summary>
        /// Свойство Максимальная скорость
        /// </summary>
        public int MaxS { get; set; }
        /// <summary>
        /// Свойство Год выпуска
        /// </summary>
        public int YearOfIssue { get; set; }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Vehicle() { }
        /// <summary>
        /// Конструктор с праметрами
        /// </summary>
        /// <param name="price"></param>
        /// <param name="maxS"></param>
        /// <param name="yearOfIssue"></param>
        public Vehicle( int price, int maxS, int yearOfIssue)
        {
            this.Price = price;
            this.MaxS = maxS;
            this.YearOfIssue = yearOfIssue;
        }
        /// <summary>
        /// абстрактный метод вывода информации
        /// </summary>
        abstract public void Print();
    }
}
