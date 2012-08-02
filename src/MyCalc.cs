using System;

namespace QuickTesting
{
    /// <summary>
    /// Very simple class for the purpose of testing
    /// </summary>
    public class MyCalc
    {
        /// <summary>
        /// Adds two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public virtual int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts b from a
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public virtual int Sub(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiplies a times b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public virtual decimal Mul(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Divides a by b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public virtual decimal Div(int a, int b)
        {
            return a / b;
        }
    }
}
