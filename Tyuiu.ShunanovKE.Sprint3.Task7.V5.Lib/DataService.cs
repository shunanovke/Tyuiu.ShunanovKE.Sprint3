using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShunanovKE.Sprint3.Task7.V5.Lib
{
    public class DataService : ISprint3Task7V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res;
            res = new double[len];
            double y;
            int cnt = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (3 * x + 1.2 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = (2 * Math.Sin(x)) / (3 * x + 1.2) + Math.Cos(x) - 7 * x * 2;
                }
                res[cnt] = Math.Round(y, 2);
                cnt++;
            }
            return res;
        }
    }
}
