using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double z, x, y, a, b; //Объявление переменных
                                  // Присваивание значения переменной
            a = 2;
            b = 1;
            //вычисление промежуточных данных
            x = a * (b + 1);
            y = b * (a + 1);
            // вычисление результата
            z = (Math.PI * (Math.Pow(x, 3) + Math.Pow(y, 3))) / (Math.Sqrt(x * y));
            z = Math.Round(z, 2); // округление числа Z до сотых
            Console.WriteLine("z=" + z);// вывод на экран	
            Console.ReadKey();//Закрытие программы после нажатия на любую клавишу

        }
    }
}
