using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NeldnerMK.Sprint3.Task2.V2.Lib;

namespace Tyuiu.NeldnerMK.Sprint3.Task2.V2.Test
{
    [TestClass]

    public class DataServiseTest
    {
        [TestMethod]

        public void ValidGetCompare()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 7;

            double wait = 135805.828;
            double res = ds.GetMultiplySeries(startValue, stopValue);
        }
    }
}