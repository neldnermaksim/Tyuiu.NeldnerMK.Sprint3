﻿using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.NeldnerMK.Sprint3.Task2.V2.Lib
{
    public class DataService : ISprint3Task2V2
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1;
            int k = startValue;

            do
            {
                p *= (Math.Sin(0.1) + k);
                k++;
            } while (k <= stopValue);

            return Math.Round(p,3);
        }
    }
}
