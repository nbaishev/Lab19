using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    class Computer
    {
        public int Code { get; set; }
        public string Label { get; set; }
        public string Proc { get; set; }
        public double Frequency { get; set; }
        public int DdrVolume { get; set; }
        public int HddVolume { get; set; }
        public int VideoVolume { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Код: {Code} Марка: {Label} Тип процессора: {Proc} Частота процессора: {Frequency:F1} Объем DDR: {DdrVolume} HDD:{HddVolume} Видеокарта: {VideoVolume} Цена :{Price:C2} Количество: {Amount}");
            //onsole.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", Code, Label, Proc, Frequency, DdrVolume, HddVolume, VideoVolume, Price, Amount);
        }
    }
}
