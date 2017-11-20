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
    public class LanguageEnhancementsTests
    {
        LanguageEnhancements test = new LanguageEnhancements();

        [TestMethod()]
        public void GetBigNumberTest()
        {

            int actual = test.GetBigNumber(); // 1_234_567
            int expected = 1234567;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SubstituteTest()
        {
            int [] numbers = { 2, 7, 1, 9, 12, 8, 15 };
            ref int position = ref test.Substitute(12, numbers);

            position = -12;

            int actual = numbers[4]; // now it is 12
            int expected = -12;

            Assert.AreEqual(actual, expected);

        }
    }
}