using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleMath4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, n, k, d, z;
            // присвоим значения переменных
            a = 3;
            n = 4;
            d = 2;
            // промежуточный вычисления 
            k = a + (n - 1) * d;
            z = ((n / 2) * (a + k));
            z = Math.Round(z, 2); // округление числа Z до сотых
            Console.WriteLine("z=" + z);// вывод на экран	
            Console.WriteLine("k=" + k);// вывод на экран	
            Console.ReadKey();//Закрытие программы после нажатия на любую клавишу


        }
    }
}
