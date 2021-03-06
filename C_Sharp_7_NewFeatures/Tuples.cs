﻿using System;
using System.Collections.Generic;

namespace C_Sharp_7_NewFeatures
{
    /// <summary>
    /// To use Tuples we need to instal System.Value.Tuple.
    /// Note this is value type, don`t mix wuth ref type: class Tuple from .Net 4.0
    /// </summary>
    public class Tuples
    {
        public void Run()
        {
            var time = GetTime();
            Console.WriteLine($"Time: {time.Item1}:{time.Item2}:{time.Item3}");

            var time2 = GetTimeNamed();
            Console.WriteLine($"Time: {time2.hours}:{time2.minutes}:{time2.seconds}");

            var tupleDictionary = new Dictionary<(int, int), string>();
            tupleDictionary.Add((100, 50), "Book is on the row 100, shelf 50");

            var result = tupleDictionary[(100, 50)];
            Console.WriteLine(result);

            //Deconstruction of tuple
            //(int hours, int minutes, int seconds) = GetTime(); /// or
            var (hoursD, minutesD, secondsD) = GetTimeDeconstruct();

            if (minutesD > 30)
                hoursD++;
            Console.WriteLine($"{hoursD}:{ minutesD}:{ secondsD}");
            //or we can deconstruct in already declared local variables:
            int a, b, c;
            (a, b, c) = GetTimeDeconstruct();

        }

        public (int, int, int) GetTime()
        {
            return (10, 20, 30); //tuple literal
        }

        public (int hours, int minutes, int seconds) GetTimeNamed()
        {
            return (10, 20, 30);
        }


        public (int, int, int) GetTimeDeconstruct() // no need names as we are going it to deconstruct
        {
            return (10, 20, 30);
        }
    }
}
