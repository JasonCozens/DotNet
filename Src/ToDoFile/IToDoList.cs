using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoFile
{
    interface IToDoList
    {
        // Command.
        void Add(string description);
        void Del();
        // Query.
        bool IsEmpty { get; }
        string Get();
    }
}
