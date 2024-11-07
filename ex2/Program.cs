using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for( int j = 1; j <= n; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }

            }
        }
    }
}
