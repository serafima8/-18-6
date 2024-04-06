using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП_18_6__Задание_1
{
    /// <summary>
    /// Производный класс Комерческое ПО
    /// </summary>
    class Commercial : Software
    {
        public double Price { get; set; }
        public DateTime Installation { get; set; }

        public int TermOfUse { get; set; }

        public Commercial() { }

        public Commercial(string name, string manufacturer, double price, DateTime installation, int termOfUse) : base(name, manufacturer)
        {
            this.Price = price;
            this.Installation = installation;
            this.TermOfUse = termOfUse;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}\nПроизводитель: {Manufacturer}\nЦена: {Price}\nДата установки: {Installation}\nСрок использования: {TermOfUse}");
        }

        static public Commercial Show()
        {
            Console.Write("Название: ");
            string name = Console.ReadLine();
            Console.Write("Производитель: ");
            string manufacturer = Console.ReadLine();
            Console.Write("Цена: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Дата установки: ");
            DateTime installation = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Срок использования: ");
            int termOfUse = Convert.ToInt32(Console.ReadLine());
            return new Commercial(name, manufacturer, price, installation, termOfUse);
        }
    }
}
