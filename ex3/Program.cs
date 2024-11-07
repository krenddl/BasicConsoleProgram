using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomnumber = rand.Next(1,10);
            
            
            for (int i = 1; i <=5 ; i++) 
            {
                int number = int.Parse(Console.ReadLine());
                if (number == randomnumber)
                {
                    Console.WriteLine("автомат 5 за 2 семестра(попал)");
                    return;
                }
                else
                {
                    Console.WriteLine("не в этот раз( (не попал)");
                }


            }
        }
    }
}


