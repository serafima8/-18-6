using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП_18_6__Задание_1
{
    /// <summary>
    /// Производный класс Условно-бусплатное ПО
    /// </summary>
    class Shareware : Software
    {
        /// <summary>
        /// Свойство Дата установки 
        /// </summary>
        public DateTime Installation { get; set; }
        /// <summary>
        /// Свойство Срок бесплатного использования 
        /// </summary>
        public int Usage { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Shareware() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="manufacturer"></param>
        /// <param name="installation"></param>
        /// <param name="usage"></param>
        public Shareware(string name, string manufacturer, DateTime installation, int usage):base(name, manufacturer)
        {
            this.Installation = installation;
            this.Usage = usage;
        }
        /// <summary>
        /// Метод для вывода информации об Условно-бусплатном ПО
        /// </summary>
        public override void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}\nПроизводитель: {Manufacturer}\nДата установки: {Installation}\nСрок бесплатного использования: {Usage} дней");
        }
        /// <summary>
        /// Метод для вывода информации о возможности использования ПО на текущую дату
        /// </summary>
        /// <returns></returns>
        public override string IsUsableOnDate()
        {
            if (DateTime.Now > Installation.AddDays(Usage))
            {
                return $"{Name} не допустимо использовать на текущую дату";
            }
            else
            {
                return $"{Name} допустимо использовать на текущую дату";
            }
        }

    }
}
