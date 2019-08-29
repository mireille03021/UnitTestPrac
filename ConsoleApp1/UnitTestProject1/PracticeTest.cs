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
        [TestMethod]
        public void Input_3_Output_Fizz()
        {
            var target = new FizzBazz();
            var actual = target.Calculate(3);
            Assert.AreEqual("Fizz", actual);
        }
        [TestMethod]
        public void Input_5_Output_Bazz()
        {
            var target = new FizzBazz();
            var actual = target.Calculate(5);
            Assert.AreEqual("Bazz", actual);
        }

        [TestMethod]
        public void Input_15_Output_FizzBazz()
        {
            var target = new FizzBazz();
            var actual = target.Calculate(15);
            Assert.AreEqual("FizzBazz", actual);
        }

    }
}
