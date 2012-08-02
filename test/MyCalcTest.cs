using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickTesting;

namespace QuickTestingUnitTests
{
    [TestClass()]
    public class MyCalcTest
    {
        private MyCalc myCalc = new MyCalc();

        /// <summary>
        /// Test the Add function
        /// </summary>
        [TestMethod()]
        public void TestAdd()
        {
            Assert.AreEqual(this.myCalc.Add(1, 1), 2);
        }

        /// <summary>
        /// Test the Subtract function
        /// </summary>
        [TestMethod()]
        public void TestSub()
        {
            Assert.AreEqual(this.myCalc.Sub(3, 2), 1);
        }

        /// <summary>
        /// Test the Multiply function
        /// </summary>
        [TestMethod()]
        public void TestMul()
        {
            Assert.AreEqual(this.myCalc.Mul(3, 2), 6);
        }

        /// <summary>
        /// Test the Division function
        /// </summary>
        [TestMethod()]
        public void TestDiv()
        {
            Assert.AreEqual(this.myCalc.Div(3, 1), 3);
        }

        /// <summary>
        /// Test that an expected exception is obtained
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivWithException()
        {
            Assert.AreEqual(this.myCalc.Div(3, 0), 1);
        }
    }
}
