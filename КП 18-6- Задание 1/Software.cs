
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
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        public Software() { }
        public Software(string name, string manufacturer)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
        }
        abstract public void DisplayInfo();
        //abstract public void IsUsableOnDate();
    }
}
