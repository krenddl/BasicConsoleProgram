﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklPar5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<=20; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                else
                    continue;


            }
        }
    }
}
