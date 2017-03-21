using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int res = ConsoleApplication2.Program.Calcul(12, 7);
            Assert.AreEqual(res, 19);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int res = ConsoleApplication2.Program.Calcul(12, -12);
            Assert.AreEqual(res, 0);
        }

    }
}
