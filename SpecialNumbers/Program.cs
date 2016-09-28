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
                int lastdigit = num % 10;
                
                int sum += lastdigit;
                sum = sum / 10;
                Console.WriteLine(lastdigit-i);
               

               
            }
        }
    }
}
