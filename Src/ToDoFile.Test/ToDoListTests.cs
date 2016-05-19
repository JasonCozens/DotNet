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
        public void ToDoLIst_IsNotEmpty_WhenTaskIsAdded()
        {
            var toDoList = new ToDoList();
            toDoList.Add("A New Task");
            Assert.AreEqual(false, toDoList.IsEmpty);
        }
    }
}
