using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значения параметра x = ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double F = (Math.Sin(x) + Math.Cos(x)) / 2;
            Console.WriteLine($"Для значения х = {x}, F = {F}.");
            Console.ReadKey();
        }
    }
}
