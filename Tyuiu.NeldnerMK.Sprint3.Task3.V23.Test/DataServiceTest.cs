using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NeldnerMK.Sprint3.Task3.V23.Lib;

namespace Tyuiu.NeldnerMK.Sprint3.Task3.V23.Test
{
    [TestClass]

    public class DataServiTest
    {
        [TestMethod]

        public void ValidGetCompare()
        {
            DataService ds = new DataService();

            string value = "fdsst siu vsrs";
            char replaceable = 's';
            char replacement = '8';

            string wait = "fd88t 8iu v8r8";
            string res = ds.ReplaceCharOnNum(value, replaceable, replacement);

            Assert.AreEqual(wait, res);
        }
    }
}