using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TitkovAA.Sprint3.Task5.V21.Lib
{
    public class DataService : ISprint3Task5V21

    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double a = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    a += x * x * x * Math.Cos(k) + 2;
                }
            }




            return Math.Round(a,3);

        }
    }
}
