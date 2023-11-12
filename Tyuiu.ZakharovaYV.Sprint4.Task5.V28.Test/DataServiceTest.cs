using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZakharovaYV.Sprint4.Task5.V28.Lib;

namespace Tyuiu.ZakharovaYV.Sprint4.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] numsmus2 = new int[5, 5] { {3, 2,-2, -6, -1},
                                              {2, -3, -4, 0, 2},
                                              {3, 1, 0, -2, -5},
                                              {1, -5, 2, 3, -4},
                                              {-4, 3, 3, -6, 1} };
            int[,] res = ds.Calculate(numsmus2);

            int[,] numsWaitmus2 ={ {3, 2, 0, 0, 0},
                                   {2, 0, 0, 0, 2},
                                   {3, 1, 0, 0, 0},
                                   {1, 0, 2, 3, 0},
                                   {0, 3, 3, 0, 1} };

            CollectionAssert.AreEqual(numsWaitmus2, res);
        }
    }
}
