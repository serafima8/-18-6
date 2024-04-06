
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП_18_6__Задание_1
{
    /// <summary>
    /// Создание базового класса ПО
    /// </summary>
    abstract class Software
    {
        /// <summary>
        /// Свойство Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Свойство Производитель
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Software() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="manufacturer"></param>
        public Software(string name, string manufacturer)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
        }
        /// <summary>
        /// Метод, который выводит информацию об объекте 
        /// </summary>
        abstract public void DisplayInfo();
        /// <summary>
        /// Метод, который выводит информацию, допустимо ли использование ПО на текущую дату 
        /// </summary>
        /// <returns></returns>
        abstract public string IsUsableOnDate();
    }
}
