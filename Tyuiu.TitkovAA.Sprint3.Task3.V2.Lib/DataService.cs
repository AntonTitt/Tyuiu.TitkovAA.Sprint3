using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TitkovAA.Sprint3.Task3.V2.Lib
{
    public class DataService : ISprint3Task3V2
    {
        public int GetMaxCharCount(string value, char item)
        {

            int a = 0, b = 0;
            bool flag = false;

            foreach (char c in value)
            {

                if (flag)
                {
                    a = 0;
                    flag = false;
                }
                if (c == item)
                {
                    a++;
                }
                else
                {
                    if (a > b)
                    {
                        b = a;
                    }
                    flag = true;
                }

            }

            return b;

        }
    }
}
