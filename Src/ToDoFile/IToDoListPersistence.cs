using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoFile
{
    public interface IToDoListPersistence
    {
        IEnumerable<string> Open(string filename);
        void Save(IEnumerable<string> toDoList);
    }
}
