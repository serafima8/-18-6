using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП_18_6__Задание_1
{
    /// <summary>
    /// Производный класс Коммерческое ПО
    /// </summary>
    class Commercial : Software
    {
        /// <summary>
        /// Свойство Цена
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Свойство Дата установки 
        /// </summary>
        public DateTime Installation { get; set; }
        /// <summary>
        /// Свойство Срок использования 
        /// </summary>
        public int TermOfUse { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Commercial() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="manufacturer"></param>
        /// <param name="price"></param>
        /// <param name="installation"></param>
        /// <param name="termOfUse"></param>
        public Commercial(string name, string manufacturer, double price, DateTime installation, int termOfUse) : base(name, manufacturer)
        {
            this.Price = price;
            this.Installation = installation;
            this.TermOfUse = termOfUse;
        }
        /// <summary>
        /// Метод, который выводит информацию об Коммерческом ПО
        /// </summary>
        public override void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}\nПроизводитель: {Manufacturer}\nЦена: {Price}\nДата установки: {Installation}\nСрок использования: {TermOfUse} дней");
        }
        /// <summary>
        /// Метод для вывода информации о возможности использования ПО на текущую дату
        /// </summary>
        /// <returns></returns>
        public override string IsUsableOnDate()
        {
            if (DateTime.Now > Installation.AddDays(TermOfUse))
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
