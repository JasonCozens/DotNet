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
            // This also checks that the Get() query doesn't change the state.
            var toDoList = new ToDoList();
            toDoList.Add("A New Task");
            Assert.AreEqual(false, toDoList.IsEmpty);
            Assert.AreEqual("A New Task", toDoList.Get());
            Assert.AreEqual(false, toDoList.IsEmpty);
        }

        [TestMethod]
        public void FirstItemAddedIsAlwaysCurrentItem()
        {
            var toDoList = new ToDoList();
            toDoList.Add("First Task");
            toDoList.Add("Second Task");
            Assert.AreEqual(false, toDoList.IsEmpty);
            Assert.AreEqual("First Task", toDoList.Get());
        }

        [TestMethod]
        public void DeletingOneItemEmptiesTheList()
        {
            var toDoList = new ToDoList();
            toDoList.Add("A New Task");
            Assert.AreEqual(false, toDoList.IsEmpty);
            toDoList.Del();
            Assert.AreEqual(true, toDoList.IsEmpty);
        }

        [TestMethod]
        public void GetItemForEmptyListThrowsException()
        {
            var toDoList = new ToDoList();
            try
            {
                toDoList.Get();
                Assert.Fail("[TEST OUTPUT] No exception thrown.");
            }
            catch (ToDoListException)
            {
                 // Is there any point in checking the message here?
            }
            catch (AssertFailedException) { throw; }
            catch (Exception ex)
            {
                Assert.Fail("[TEST OUTPUT] Incorrect Exception {0}", ex);
            }
        }

        [TestMethod]
        public void DelItemForEmptyListThrowsException()
        {
            var toDoList = new ToDoList();
            try
            {
                toDoList.Del();
                Assert.Fail("[TEST OUTPUT] No exception thrown.");
            }
            catch (ToDoListException)
            {
                // Is there any point in checking the message here?
            }
            catch (AssertFailedException) { throw; }
            catch (Exception ex)
            {
                Assert.Fail("[TEST OUTPUT] Incorrect Exception {0}", ex);
            }
        }
    }
}
