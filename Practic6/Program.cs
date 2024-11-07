using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число n  ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            double y = 0;
            for (int i = (2*n+1); i>=1; i-=2) 
            {
                y = Math.Sqrt(y + i);
            }
            Console.WriteLine(y);
        } 
            
    }
}
