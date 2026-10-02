using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    public class MinMaxBase
    {
        protected virtual int[] GetNumbers() => new int[0];

        public void Run()
        {
            int[] numbers = GetNumbers();
            Console.WriteLine($"Min: {numbers.Min()}, Max: {numbers.Max()}");
        }
    }
}
