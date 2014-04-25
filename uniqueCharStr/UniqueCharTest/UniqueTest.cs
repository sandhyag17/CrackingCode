using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UniqueCharTest
{
    [TestClass]
    public class UniqueTest
    {
        [TestMethod]
        public void extractTest_PASS()
        {
            //arrange
            string InputString = "AKJAJKSJAHSKJ";
            string expected = "AKJSH";

            //act

            string actual = uniqueCharStr.ClassUnique.extract(InputString);
            //assert

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void extractTest_Fail()
        {
            //arrange
            string InputString = "AKJAJKSJAHSKJ";
            string expected = "KJSH";

            //act

            string actual = uniqueCharStr.ClassUnique.extract(InputString);
            //assert

            Assert.AreEqual(expected, actual);

        }
    }
}
