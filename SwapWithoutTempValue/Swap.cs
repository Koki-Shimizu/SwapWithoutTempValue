using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapWithoutTempValue
{
    public class SwapService
    {
        public static void Swap(ref int src, ref int dest)
        {
            src = src^dest;
            dest = src^dest;
            src = src^dest;
        }
    }
}
