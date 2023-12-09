using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TitkovAA.Sprint3.Task4.V9.Lib
{
    public class DataService : ISprint3Task4V9
    {
        public double Calculate(int startValue, int stopValue)
        {
            double r = 1;
            for (int x = 0; x <= startValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                else
                {
                    r *= x / (Math.Cos(x) - x);
                }
            }


            return Math.Round(r);
        }
    }
}
