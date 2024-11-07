using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    if (i != j)
                        Console.Write($"{i} ");
                    else
                        Console.WriteLine($"{i} ");
                }

            }
        }
    }
}
