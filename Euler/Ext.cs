using System;
using System.Collections.Generic;
using System.Text;

namespace Euler
{
    static class Ext
    {
        public static int Pow(this int x, uint pow)
        {
            int ret = 1;
            while (pow != 0)
            {
                if ((pow & 1) == 1)
                    ret *= x;
                x *= x;
                pow >>= 1;
            }
            return ret;
        }
    }
}
