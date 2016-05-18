using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoFile.Test.Mocks
{
    internal class MockIToDoListPersistence : IToDoListPersistence
    {
        private IEnumerable<string> _toDoList;

        public MockIToDoListPersistence()
        {
            _toDoList = new List<string>();
        }

        public MockIToDoListPersistence(IEnumerable<string> toDoList)
        {
            _toDoList = toDoList;
        }

        public IEnumerable<string> Open(string filename)
        {
            return _toDoList;
        }

        public void Save(IEnumerable<string> toDoList)
        {
            throw new NotImplementedException();
        }
    }
}
