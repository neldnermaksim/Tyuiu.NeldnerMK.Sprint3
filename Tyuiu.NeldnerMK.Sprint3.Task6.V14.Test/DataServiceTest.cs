using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NeldnerMK.Sprint3.Task6.V14.Lib;

namespace Tyuiu.NeldnerMK.Sprint3.Task6.V14.Test
{
    [TestClass]

    public class DataServiseTest
    {
        [TestMethod]
        public void ValidGetCompare()
        {
            DataService ds = new DataService();
            int startValue = 7;
            int stopValue = 16;

            int wait = 13;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
        }
    }
}
