using Microsoft.VisualStudio.TestTools.UnitTesting;
using C_Sharp_7_NewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_7_NewFeatures.Tests
{
    [TestClass()]
    public class LocalFunctionsTests
    {
        [TestMethod()]
        public void FibonacciTest()
        {
            var test = new LocalFunctions();
            int target = 6;

            int actual = test.Fibonacci(target);
            int expected = 13;
            
            Assert.AreEqual(actual, expected);
        }
    }
}