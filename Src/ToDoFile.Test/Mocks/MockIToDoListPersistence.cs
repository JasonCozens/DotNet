using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoFile.Test.Mocks
{
    internal class MockIToDoListPersistence : IToDoListPersistence
    {
        public IEnumerable<string> Open(string filename)
        {
            return new List<string>();
        }

        public void Save(IEnumerable<string> toDoList)
        {
            throw new NotImplementedException();
        }
    }
}
