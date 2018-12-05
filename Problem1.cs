using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{

    class Problem1
    {

        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int final = 0;
            for (int a0 = 0; a0 < t; a0++)
            {
                if (a0 / 3 > 0 && a0 % 3 == 0 || a0 / 5 > 0 && a0 % 5 == 0)
                {
                    final += a0;
                }
            }
            Console.WriteLine(final);
            Console.ReadLine();
        }
    }
}