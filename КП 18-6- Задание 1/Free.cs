using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП_18_6__Задание_1
{
    /// <summary>
    /// Создание произодного класса Свободное ПО
    /// </summary>
    class Free : Software
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Free() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="manufacturer"></param>
        public Free(string name, string manufacturer):base(name, manufacturer)  { }
        /// <summary>
        /// Метод, который выводит информацию о Свободном ПО
        /// </summary>
        public override void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}\nПроизводитель: {Manufacturer}");
        }
        /// <summary>
        /// Метод для вывода информации о возможности использования ПО на текущую дату
        /// </summary>
        /// <returns></returns>
        public override string IsUsableOnDate()
        {
            return $"{Name} допустимо использовать на текущую дату";
        }

    }
}
