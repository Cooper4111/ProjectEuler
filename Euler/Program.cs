using System;
using System.Diagnostics;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            EU5test();
        }

        static void EU4test()
        {
            // 91x99   = 9009
            // 913x993 = 906609

            EU4 foo = new EU4();
            var res = foo.GetMaxPal(3);
            Console.WriteLine(res);
        }

        static void EU5test()
        {
            var sw = Stopwatch.StartNew();
            sw.Start();
            var v = Tools.GetPrimesUp2(19);
            sw.Stop();
            foreach (int p in v)
            {
                Console.Write(p);
                Console.Write("\t");
            }
            Console.WriteLine();
            Console.WriteLine($"Time: {sw.ElapsedMilliseconds/1000}.{sw.ElapsedMilliseconds % 1000}");
        }
    }
}
