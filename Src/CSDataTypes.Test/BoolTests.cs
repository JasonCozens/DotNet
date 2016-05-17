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
    }
}
