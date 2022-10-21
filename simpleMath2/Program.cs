using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleMath2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double z, x, y, a, b;// объявление переменных
            // присваивание значения переменной
            a = 2;
            b = 4;
            //вычисление промежуточных данных
            x = (Math.Pow(a, 2)) / (Math.Pow(b, 2));
            y = (Math.Pow(a, 2)) + (2 * (Math.Pow(b, 2)));
            // вычисление результата
            z = (((Math.Pow(x, 2)) + (Math.Pow(y, 2)) + (x * y)) * (Math.Sqrt(x / y)) / 2);
            z = Math.Round(z, 2); // округление числа Z до сотых
            Console.WriteLine("z=" + z);// вывод на экран
            Console.WriteLine("x=" + x); // вывод на экран
            Console.WriteLine("y=" + y);// вывод на экран
            Console.ReadKey();//Закрытие программы после нажатия на любую клавишу

        }
    }
}
