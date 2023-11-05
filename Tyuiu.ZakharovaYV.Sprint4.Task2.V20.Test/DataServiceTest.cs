using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZakharovaYV.Sprint4.Task2.V20.Lib;

namespace Tyuiu.ZakharovaYV.Sprint4.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 5, 3, 7, 2, 6, 2, 5, 5, 7, 4, 6, 7, 4, 2, 3 };

            int res = ds.Calculate(numsArray);
            int wait = 28;

            Assert.AreEqual(wait, res);
        }
    }
}
