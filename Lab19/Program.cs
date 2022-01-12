using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> listComputer = new List<Computer>()
            {
                new Computer() { Code=1, Label="Lenovo", Proc="Ryzen", Frequency=1.1, DdrVolume=4, HddVolume=128, VideoVolume=2, Price=2000, Amount=5},
                new Computer() { Code=2, Label="HP", Proc="Intel", Frequency=2.2, DdrVolume=4, HddVolume=256, VideoVolume=4, Price=5000, Amount=1},
                new Computer() { Code=3, Label="MSI", Proc="Intel", Frequency=3.2, DdrVolume=16, HddVolume=1024, VideoVolume=6, Price=20000, Amount=3},
                new Computer() { Code=4, Label="Lenovo", Proc="Intel", Frequency=2.5, DdrVolume=8, HddVolume=512, VideoVolume=6, Price=8000, Amount=4},
                new Computer() { Code=5, Label="Acer", Proc="Ryzen", Frequency=1.1, DdrVolume=4, HddVolume=128, VideoVolume=4, Price=6000, Amount=10},
                new Computer() { Code=6, Label="Asus", Proc="Intel", Frequency=1.1, DdrVolume=4, HddVolume=128, VideoVolume=2, Price=2000, Amount=2},
                new Computer() { Code=7, Label="Lenovo", Proc="Intel", Frequency=3.2, DdrVolume=16, HddVolume=512, VideoVolume=4, Price=4000, Amount=5},
                new Computer() { Code=8, Label="HP", Proc="Intel", Frequency=1.5, DdrVolume=4, HddVolume=256, VideoVolume=4, Price=8000, Amount=6},
                new Computer() { Code=9, Label="MSI", Proc="Ryzen", Frequency=2.5, DdrVolume=8, HddVolume=256, VideoVolume=6, Price=10000, Amount=2},
                new Computer() { Code=10, Label="Lenovo", Proc="Intel", Frequency=2.2, DdrVolume=6, HddVolume=512, VideoVolume=2, Price=10000, Amount=3},
            };
            Console.WriteLine("Введите тип процессора");
            string procF = Console.ReadLine();
            List<Computer> computers = listComputer
                .Where(c => c.Proc == procF)
                .ToList();
            CultureInfo.CurrentCulture = new CultureInfo("us-US", false);
            foreach (var comp in computers)
            {
                comp.ShowInfo();
            }
            Console.WriteLine();
            Console.WriteLine("Введите минимальный объем оперативной памяти");
            int ddrF = Convert.ToInt32(Console.ReadLine());
            List<Computer> computersDdr = listComputer
                .Where(c => c.DdrVolume >= ddrF)
                .ToList();
            foreach (var comp in computersDdr)
            {
                comp.ShowInfo();
            }
            Console.WriteLine();
            Console.WriteLine("Сортировка компьютеров по цене");
            List<Computer> computersSortByPrice = listComputer
                .OrderBy(c => c.Price)
                .ToList();
            foreach (var comp in computersSortByPrice)
            {
                comp.ShowInfo();
            }
            Console.WriteLine();
            Console.WriteLine("Группировка компьютеров по типу процессора");

            var computersGroupByProc = listComputer
                .GroupBy(c => c.Proc);

            foreach (IGrouping<string, Computer> comp in computersGroupByProc)
            {
                Console.WriteLine(comp.Key);
                foreach (var t in comp)
                    t.ShowInfo();
                Console.WriteLine();
            }

            double compMax = listComputer
                    .Max(c => c.Price);
            Console.WriteLine("Самый дорогой компьютер {0}", compMax);

            double compMin = listComputer
                    .Min(c => c.Price);
            Console.WriteLine("Самый бюджетный компьютер {0}", compMin);

            bool amount30 = listComputer
                .Any(c => c.Amount>=30);
            if (amount30)
            {
                Console.WriteLine("В наличии есть 30 штук");
            }
            else
            {
                Console.WriteLine("В наличии нет 30 штук");
            }
            Console.ReadKey();
        }
    }
}
