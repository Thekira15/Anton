using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassLibrary;
namespace UnitTestProject1
{
    [TestClass]
    public class gtest
    {
        [TestMethod]
        public void biba()
        {
            int a = 3;
            int b = 5;
            int exp = 15;

            Geo g = new Geo();
            int actual = g.recarea(a, b);
            Assert.AreEqual(exp, actual);
        }
    }
}
