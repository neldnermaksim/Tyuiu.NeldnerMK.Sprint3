using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NeldnerMK.Sprint3.Task5.V22.Lib;

namespace Tyuiu.NeldnerMK.Sprint3.Task5.V22.Test
{
    [TestClass]

    public class DataServiseTest
    {
        [TestMethod]
        public void ValidGetCompare()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue = 1;
            int stopValue = 3;
            int startValue1 = 1;
            int stopValue2 = 12;

            double wait = 22.997;
            double res = ds.GetSumSumSeries(x, startValue, startValue, startValue1, stopValue2);

            Assert.AreEqual(wait, res);

        }
    }
}
