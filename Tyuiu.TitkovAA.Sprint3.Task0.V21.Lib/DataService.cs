using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TitkovAA.Sprint3.Task0.V21.Lib
{
    public class DataService : ISprint3Task0V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double a = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                a += (Math.Pow(value, i) + 0.25) * Math.Sin(i);
            }



            return a;
        }
    }
}
