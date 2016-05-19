using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToDoFile.Test
{
    [TestClass]
    public class ToDoListTests
    {
        [TestMethod]
        public void NewToDoList_IsEmpty()
        {
            var toDoList = new ToDoList();
            Assert.AreEqual(true, toDoList.IsEmpty);
        }

        [TestMethod]
        public void ToDoList_IsNotEmpty_WhenTaskIsAdded()
        {
            var toDoList = new ToDoList();
            toDoList.Add("A New Task");
            Assert.AreEqual(false, toDoList.IsEmpty);
        }

        [TestMethod]
        public void ToDoList_Added_ItenIsReturned()
        {
            var toDoList = new ToDoList();
            toDoList.Add("A New Task");
            Assert.AreEqual(false, toDoList.IsEmpty);
            Assert.AreEqual("A New Task", toDoList.Get());
        }
    }
}
