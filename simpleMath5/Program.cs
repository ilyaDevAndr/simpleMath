using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleMath5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double z, r, a, n;
            // присвоим значение переменных 
            a = 2;
            n = 4;
            r = (Math.Sqrt(a) / 3);
            z = a * (n - r) / (1 - r);
            z = Math.Round(z, 2); // округление числа Z до сотых
            Console.WriteLine("z=" + z);// вывод на экран	
            Console.ReadKey();//Закрытие программы после нажатия на любую клавишу

        }
    }
}
