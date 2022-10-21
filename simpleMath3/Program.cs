using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleMath3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p, a, b, c, z;
            a = 2;
            b = 4;
            c = 5;
            p = (a + b + c) / 2;
            z = 2 * ((Math.Sqrt(p * (p - a) * (p - b) * (p - c))) / a);
            z = Math.Round(z, 2); // округление числа Z до сотых
            Console.WriteLine("z=" + z);// вывод на экран	
            Console.WriteLine("p=" + p);// вывод на экран	
            Console.ReadKey();//Закрытие программы после нажатия на любую клавишу

        }
    }
}
