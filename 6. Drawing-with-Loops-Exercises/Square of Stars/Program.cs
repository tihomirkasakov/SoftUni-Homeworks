﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int col = 1; col <= n; col++)
            {
                for (int row = 1; row < n; row++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
