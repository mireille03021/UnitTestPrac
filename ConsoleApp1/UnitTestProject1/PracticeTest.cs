using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class PracticeTest
    {
        [TestMethod]
        public void Input_1_Output_1()
        {
            var target = new FizzBazz();
            var actual = target.Calculate(1);
            Assert.AreEqual("1",actual);
        }
    }
}
