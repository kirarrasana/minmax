using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    public class MinMax_v2 : MinMaxBase
    {
        protected override int[] GetNumbers()
        {
            Console.Write("Введите кол-во элементов: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите число: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            return numbers;
        }
    }
}
