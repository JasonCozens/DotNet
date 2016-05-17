using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSDataTypes.Test
{
    [TestClass]
    public class BoolTests
    {
        [TestMethod]
        public void IsTrueTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void IsFalseTest()
        {
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void EquivalenceTest()
        {
            Assert.IsTrue(true == true);
            Assert.IsTrue(false == false);
            Assert.IsFalse(true == false);
            Assert.IsFalse(false == true);
        }

        [TestMethod]
        public void GetTypeTest()
        {
            var boolType = true.GetType();
            Assert.AreEqual("System.Boolean", boolType.FullName);
        }
    }
}
