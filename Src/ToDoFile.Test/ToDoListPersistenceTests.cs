using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO.Prig;
using Urasandesu.Prig.Framework;

namespace ToDoFile.Test
{
    [TestClass]
    public class ToDoListPersistenceTests
    {
        [TestMethod]
        public void OpenEmptyFile_Test()
        {
            using (new IndirectionsContext())
            {
                var toDoListPerssistence = new ToDoListPersistence();
                string actualPath = "";
                PFile.OpenTextString().Body = path => { actualPath = path; return new StreamReader(new MemoryStream()); };
                var toDoList = toDoListPerssistence.Open("todo.txt");
                Assert.AreEqual(0, toDoList.ToList().Count);
            }
        }
    }
}
