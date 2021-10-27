using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building("Строителей 12", 12.6, 6, 7.2);
            Console.WriteLine(building1.Print());
            MultiBuilding building2 = new MultiBuilding("Строителей 15", 9.2, 6, 7.2, 2);
            Console.WriteLine(building2.Print());
            Console.ReadKey();
        }
        class Building
        {
            public string Address { get; set; }
            public double Lengh { get; set; }
            public double Width { get; set; }
            public double Hight { get; set; }
            public Building()
            {

            }
            public Building(string address, double lengh, double width, double hight)
            {
                Address = address;
                Lengh = lengh;
                Width = width;
                Hight = hight;
            }
            public string Print()
            {
                string print = "Адрес: " + Address + "\nРазмеры: " + Lengh + " x " + Width + " x " + Hight;
                return print;
            }
        }
        sealed class MultiBuilding : Building
        {
            public int Storeys { get; set; }
            public MultiBuilding(string address, double lengh, double width, double hight, int storeys)
                : base(address, lengh, width, hight)
            {
                Storeys = storeys;
            }
        }
    }
}
