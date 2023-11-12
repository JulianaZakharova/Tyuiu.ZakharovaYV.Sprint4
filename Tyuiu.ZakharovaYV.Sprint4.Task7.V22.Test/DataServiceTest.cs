using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZakharovaYV.Sprint4.Task7.V22.Lib;

namespace Tyuiu.ZakharovaYV.Sprint4.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "695324951753684";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 9216;
            Assert.AreEqual(wait, res);
        }
    }
}
