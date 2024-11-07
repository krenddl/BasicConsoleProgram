using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklPar4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("число n");
            int n= int.Parse(Console.ReadLine());
            Console.WriteLine("число k");
            int k = int.Parse(Console.ReadLine());
            double p = 0;
            for (int i = 1; i<=n; i++)
            {
                for (int j = 1;j<=k; j++)
                {
                    p += (Math.Pow(i, j));
                    Console.WriteLine(p);
                }
            }

        }
    }
}
