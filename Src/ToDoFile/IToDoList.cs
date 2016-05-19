using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoFile
{
    interface IToDoList
    {
        bool IsEmpty { get; }
        void Add(string description);
        string Get();
        void Del();
    }
}
