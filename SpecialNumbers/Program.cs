using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                int sumLastDigits = 0;
                int digits = i;
                while (digits>0)
                {
                    sumLastDigits += digits % 10;
                    digits = digits / 10;
                }
                bool special = (sumLastDigits == 5) || (sumLastDigits == 7) || (sumLastDigits == 11);
                Console.WriteLine("{0} -> {1}",i,special);
            }
        }
    }
}
