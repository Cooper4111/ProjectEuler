using System;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            // 913x993 = 906609

            EU4 foo = new EU4();
            var res = foo.GetMaxPal(3);
            Console.WriteLine(res);
        }
    }
}
