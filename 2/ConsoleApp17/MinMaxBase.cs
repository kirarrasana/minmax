using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    public class MinMaxBase
    {
        public int Min(int[] numbers)
        {
            return numbers.Min();
        }

        public int Max(int[] numbers)
        {
            return numbers.Max();
        }
    }

}
