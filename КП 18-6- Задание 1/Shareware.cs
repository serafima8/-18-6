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
        public DateTime Installation { get; set; }
        public int Usage { get; set; }

        public Shareware() { }
        public Shareware(string name, string manufacturer, DateTime installation, int usage):base(name, manufacturer)
        {
            this.Installation = installation;
            this.Usage = usage;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}\nПроизводитель: {Manufacturer}\nДата установки: {Installation}\nСрок бесплатного использования: {Usage}");
        }

        static public Shareware Show()
        {
            Console.Write("Название: ");
            string name = Console.ReadLine();
            Console.Write("Производитель: ");
            string manufacturer = Console.ReadLine();
            Console.Write("Дата установки: ");
            DateTime installation = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Срок бесплатного использования: ");
            int usage = Convert.ToInt32(Console.ReadLine());
            return new Shareware(name, manufacturer, installation, usage);
        }

    }
}
