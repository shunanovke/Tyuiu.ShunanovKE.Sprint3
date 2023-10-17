using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.ShunanovKE.Sprint3.Task0.V30.Lib
{
    public class DataService : ISprint3Task0V30
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double res = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                res *= (i / Math.Pow(Math.Sin(1), -10));
            }
            return Math.Round(res, 3);
        }
    }
}
