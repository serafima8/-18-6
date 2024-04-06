using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП_18_6__Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Полная информация из базы: ");
            Free free = new Free();
            free.Name = "Notepad++";
            free.Manufacturer = "Notepad++ Team";
            Shareware shareware = new Shareware();
            shareware.Name = "Adobe Photoshop";
            shareware.Manufacturer = "Adobe";
            shareware.Installation = new DateTime(2024, 02, 14);
            shareware.Usage = 30;
            Commercial commercial = new Commercial();
            commercial.Name = "Microsoft Office";
            commercial.Manufacturer = "Microsoft";
            commercial.Price = 1000;
            commercial.Installation = new DateTime(2023, 12, 26);
            commercial.TermOfUse = 365;
            List<Software> softwares = new List<Software>()
            { free, shareware, commercial  };
            foreach(var elem in softwares)
            {
                elem.DisplayInfo();
            }
            foreach (var elem in softwares)
            {

                Console.WriteLine(elem.IsUsableOnDate());
            }
            Console.ReadKey();
        }
    }
}
