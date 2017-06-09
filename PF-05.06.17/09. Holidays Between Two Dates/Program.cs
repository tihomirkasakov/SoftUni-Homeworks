﻿using System;
using System.Globalization;

namespace _09.Holidays_Between_Two_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),"dd.mm.yyyy", DateTimeFormatInfo.InvariantInfo);
            var endDate = DateTime.ParseExact(Console.ReadLine(),"dd.mm.yyyy", DateTimeFormatInfo.InvariantInfo);
            var holidaysCount = 0;

            for (var date = startDate; date <= endDate; date.AddDays(1))
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            Console.WriteLine(holidaysCount);
        }
    }
}
