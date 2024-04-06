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
        public Free() { }
        public Free(string name, string manufacturer):base(name, manufacturer)  { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}\nПроизводитель: {Manufacturer}");
        }
        //public override void IsUsableOnDate()
        //{
           
        //}

        static public Free Show()
        {
            Console.Write("Название: ");
            string name = Console.ReadLine();
            Console.Write("Производитель: ");
            string manufacturer = Console.ReadLine();
            return new Free(name, manufacturer);
        }
    }
}
