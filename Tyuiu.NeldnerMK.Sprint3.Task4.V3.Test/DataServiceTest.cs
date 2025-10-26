using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NeldnerMK.Sprint3.Task4.V3.Lib;

namespace Tyuiu.NeldnerMK.Sprint3.Task4.V3.Test
{
    [TestClass]

    public class DataServiseTest
    {
        [TestMethod]
        public void ValidGetCompare()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double wait = 1.067;
            double res = ds.Calculate(startValue, stopValue);

            Assert.AreEqual(wait, res);

        }
    }
}