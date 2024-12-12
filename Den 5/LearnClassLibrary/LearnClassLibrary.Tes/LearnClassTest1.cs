using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnClassLibrary.Tes
{
    [TestClass]
    public class LearnClassTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int a = 2;
            int b = 3;
            int expected = 7380;
            //act
            LearnClass c = new LearnClass();
            int actual = c.TimeInSecunds(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            int a = 7380;
            int hour = 2;
            int min = 3;
            //act
            LearnClass c = new LearnClass();
            int actual1 = c.TimeInHour(a);
            int actual2 = c.TimeInMin(a);
            //assert
            Assert.AreEqual(hour, actual1);
            Assert.AreEqual(min, actual2);
        }
    }
}
