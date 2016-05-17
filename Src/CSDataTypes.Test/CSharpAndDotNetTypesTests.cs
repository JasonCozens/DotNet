using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSDataTypes.Test
{
    /// <summary>
    /// This test class shows the mapping between scharp types and the .NET
    /// CLR.
    /// </summary>
    [TestClass]
    public class CSharpAndDotNetTypesTests
    {
        [TestMethod]
        public void BoolTest()
        {
            Assert.AreEqual(Type.GetType("System.Boolean"), typeof(bool));
        }

        [TestMethod]
        public void ByteTest()
        {
            Assert.AreEqual(Type.GetType("System.Byte"), typeof(byte));
            Assert.AreEqual(Type.GetType("System.SByte"), typeof(sbyte));
        }

        [TestMethod]
        public void CharAndStringTest()
        {
            Assert.AreEqual(Type.GetType("System.Char"), typeof(char));
            Assert.AreEqual(Type.GetType("System.String"), typeof(string));
        }

        [TestMethod]
        public void ObjectTest()
        {
            Assert.AreEqual(Type.GetType("System.Object"), typeof(object));
        }

        [TestMethod]
        public void NumericTypesTest()
        {
            Assert.AreEqual(Type.GetType("System.Decimal"), typeof(decimal));
            Assert.AreEqual(Type.GetType("System.Double"), typeof(double));
            Assert.AreEqual(Type.GetType("System.Single"), typeof(float));
            Assert.AreEqual(Type.GetType("System.Int32"), typeof(int));
            Assert.AreEqual(Type.GetType("System.UInt32"), typeof(uint));
            Assert.AreEqual(Type.GetType("System.Int64"), typeof(long));
            Assert.AreEqual(Type.GetType("System.UInt64"), typeof(ulong));
            Assert.AreEqual(Type.GetType("System.Int16"), typeof(short));
            Assert.AreEqual(Type.GetType("System.UInt16"), typeof(ushort));
        }
    }
}
