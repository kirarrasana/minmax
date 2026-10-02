using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    public class MinMax_v1 : MinMaxBase
    {
        protected override int[] GetNumbers()
        {
            return new int[] { 1, -2, 3, 4, 5, 6 };
        }
    }
}
