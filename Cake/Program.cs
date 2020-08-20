using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаём рандомное число.
            Random rnd = new Random();
            int N = rnd.Next(1, 100);
            //если остаток при делении ноль.
            if (N % 2 == 0)
            {
                // делим число пополам.
                int Sum = N / 2;
                Console.WriteLine($" нужно сделать {Sum} разрезов. ");
            }
            // если нет, выводим рандомное число.
            else
            {
                Console.WriteLine($"нужно сделать {N} разрезов.");
            }
            Console.ReadKey();
        }
    }
}
