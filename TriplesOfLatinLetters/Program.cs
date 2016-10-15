using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i =0; i <=n; i++)
            {
                for (int z = 0; z < n; z++)
                {
                    for (int y = 0; y < n; y++)
                    {
                        char letter1 = (char)('a' + i);
                        char letter2 = (char)('a' + z);
                        char letter3 = (char)('a' + y);
                        Console.WriteLine("{0}{1}{2}", letter1,letter2,letter3);
                    }
                }  
            }
        }
    }
}
