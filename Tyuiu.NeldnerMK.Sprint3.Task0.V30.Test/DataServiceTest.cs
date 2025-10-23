using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NeldnerMK.Sprint3.Task0.V30.Lib;

namespace Tyuiu.NeldnerMK.Sprint3.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompare()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 20;

            double wait = 2477.158;
            double value = ds.GetMultiplySeries(startValue, stopValue);

            Assert.AreEqual(wait, value, 0.001);
        }
    }
}