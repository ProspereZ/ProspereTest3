using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProspereTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=20; i++)
            {
                Console.WriteLine(i);
                if(i % 2 ==0)
                {
                    Console.WriteLine(0);
                }
            }
              
        }
    }
}
