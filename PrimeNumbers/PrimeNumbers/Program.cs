using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {   //для оптимизации кода, мы создаем функцию, которая будет проверять число на простоту, и передаем в нее одно значение
        static bool IsPrime(string s)
        {   //конвертируем значение из типа string в тип integer
            int x = int.Parse(s);
            //заводим счетчик, который покажет, на сколько чисел данное значение делится без остатка
            int cnt = 0;
            //подсчет количества делителей, отличных от 1 и самого числа
            for (int j = 2; j <= Math.Sqrt(x); j++)
            {
                if (x % j == 0)
                {
                    cnt++;
                }
            }
            //1 - простое число
            return cnt == 0 && x != 1;
        }
        static void Main(string[] args2)
        {   //для считывания значений с консоли вводится переменная, в которую передаются эти значения
            string y = Console.ReadLine();
            //т.к. значения вводились как строка, необходимо преобразовать их в элементы массива
            //данная функция воспринимает пробел как разделитель, а значения - как нужные элементы
            string[] args = y.Split(' ');
            //проверка каждого элемента массива на простоту
            for (int i = 0; i < args.Length; i++)
            {
                if (!IsPrime(args[i]))
                {
                    Console.WriteLine(args[i] + " is not prime");
                }
                else
                {
                    Console.WriteLine(args[i] + " is prime");
                }
            }

        }
    }
}
