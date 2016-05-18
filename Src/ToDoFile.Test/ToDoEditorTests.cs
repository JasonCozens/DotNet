using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO.Prig;
using System.IO;
using Urasandesu.Prig.Framework;
using ToDoFile.Test.Mocks;
using System.Collections.Generic;

namespace ToDoFile.Test
{
    [TestClass]
    public class ToDoEditorTests
    {
        /// <summary>
        /// This is the method that gave problems with setting up the internal list.
        /// </summary>
        [TestMethod]
        public void AddToDoItem_Test()
        {
            var toDoEditor = new ToDoEditor(new MockIToDoListPersistence());
            toDoEditor.Add("The First Task");
            Assert.AreEqual(1, toDoEditor.Count);
        }

        [TestMethod]
        public void ToDoList_IsImportedCorrectly_Test()
        {
            var toDoList = new List<string>
            {
                "Task 1.",
                "Task 2.",
                "Task 3."
            };
            var toDoEditor = new ToDoEditor(new MockIToDoListPersistence(toDoList));
            Assert.AreEqual(3, toDoEditor.Count);
        }
    }
}
