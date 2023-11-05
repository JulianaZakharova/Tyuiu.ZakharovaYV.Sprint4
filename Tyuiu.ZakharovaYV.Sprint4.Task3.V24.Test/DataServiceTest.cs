using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZakharovaYV.Sprint4.Task3.V24.Lib;

namespace Tyuiu.ZakharovaYV.Sprint4.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { {3, 6, 1, 7, 3},
                                          {2, 3, 7, 1, 1},
                                          {1, 2, 5, 5, 1},
                                          {7, 6, 7, 6, 2},
                                          {7, 6, 4, 5, 8} };
            int res = ds.Calculate(mas2);
            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}
