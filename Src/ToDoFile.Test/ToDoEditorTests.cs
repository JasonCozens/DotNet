using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToDoFile.Test
{
    [TestClass]
    public class ToDoEditorTests
    {
        [TestMethod]
        public void NewToDoEditor_HasNoItems_Test()
        {
            var toDoEditor = new ToDoEditor();
            Assert.AreEqual(0, toDoEditor.Count);
        }
    }
}
