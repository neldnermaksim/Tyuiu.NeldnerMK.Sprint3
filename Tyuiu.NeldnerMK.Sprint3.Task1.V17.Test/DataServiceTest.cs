using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NeldnerMK.Sprint3.Task1.V17.Lib;

namespace Tyuiu.NeldnerMK.Sprint3.Task1.V17.Test
{
    [TestClass]

    public class DataServiseTest
    {
        [TestMethod]

        public void ValidGetCompare()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 4;

            double wait = 482982.891;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            Assert.AreEqual(wait, res, 0.001);
        }
    }
}