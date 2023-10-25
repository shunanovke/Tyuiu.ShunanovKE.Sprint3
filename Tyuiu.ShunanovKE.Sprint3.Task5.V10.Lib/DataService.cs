﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShunanovKE.Sprint3.Task5.V10.Lib
{
    public class DataService : ISprint3Task5V10
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    res += (x * x * x * k) + 2;
                }
            }
            return Math.Round(res, 3);
        }
    }
}
