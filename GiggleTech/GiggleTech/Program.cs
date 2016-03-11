using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiggleTech
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 32;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Random Number " + i + " : " + Convert.ToBase64String(Random.GenerateRAndomNumber(length)));
            }
            Console.ReadLine();
        }
    }
}
