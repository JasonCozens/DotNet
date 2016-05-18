using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO.Prig;
using System.IO;
using Urasandesu.Prig.Framework;

namespace ToDoFile.Test
{
    [TestClass]
    public class ToDoEditorTests
    {
        [TestMethod]
        public void NewToDoEditor_HasNoItems_Test()
        {
            var toDoEditor = new ToDoEditor();
            Assert.AreEqual("", toDoEditor.CurrentFile);
            Assert.AreEqual(0, toDoEditor.Count);
        }

        [TestMethod]
        public void OpenFile_FileNotFoundException_Test()
        {
            using (new IndirectionsContext())
            {
                var toDoEditor = new ToDoEditor();
                string actualPath = "";
                PFile.OpenTextString().Body = path => { actualPath = path; throw new FileNotFoundException("", path); };
                toDoEditor.Open("todo.txt");
                Assert.AreEqual("", toDoEditor.CurrentFile);
                var message = toDoEditor.Message;
                Assert.IsTrue(message.Contains("todo.txt"), message);
            }
        }

        [TestMethod]
        public void OpenFile_Test()
        {
            using (new IndirectionsContext())
            {
                var toDoEditor = new ToDoEditor();
                string actualPath = "";
                PFile.OpenTextString().Body = path => { actualPath = path; return null; };
                toDoEditor.Open("todo.txt");
                Assert.AreEqual("todo.txt", actualPath);
            }
        }
    }
}
