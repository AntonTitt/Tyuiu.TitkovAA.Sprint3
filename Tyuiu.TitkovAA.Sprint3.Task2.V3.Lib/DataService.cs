﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TitkovAA.Sprint3.Task2.V3.Lib
{
    public class DataService : ISprint3Task2V3
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {

            double a = 0;
            do
            {
                a += (value * value * startValue) + 1;
                startValue++;
            }
            while (startValue < stopValue);

            return a;
        }
    }
}
