using System;
using static System.Convert;
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

        [TestMethod]
        public void TypeOfTest()
        {
            var boolType = typeof(bool);
            Assert.AreEqual("System.Boolean", boolType.FullName);
        }

        [TestMethod]
        public void TypeOf_SameAs_GetType_Test()
        {
            Assert.AreEqual(true.GetType(), typeof(bool));
        }

        [TestMethod]
        public void ToStringTest()
        {
            Assert.AreEqual("True", true.ToString());
            Assert.AreEqual("False", false.ToString());
            Assert.AreEqual("System.Boolean", true.GetType().ToString());
        }

        [TestMethod]
        public void ToNumTypeTest()
        {
            Assert.AreEqual(1, ToByte(true));
            Assert.AreEqual(0, ToByte(false));
            Assert.AreEqual(1, ToDecimal(true));
            Assert.AreEqual(0, ToDecimal(false));
            Assert.AreEqual(1, ToDouble(true));
            Assert.AreEqual(0, ToDouble(false));
        }
    }
}
