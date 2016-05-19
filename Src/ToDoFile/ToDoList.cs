using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoFile
{
    public class ToDoList : IToDoList
    {
        readonly Queue<string> _toDoList = new Queue<string>();

        public bool IsEmpty
        {
            get
            {
                return _toDoList.Count == 0;
            }
        }

        public void Add(string description)
        {
            _toDoList.Enqueue(description);
        }

        public void Del()
        {
            if (_toDoList.Count == 0)
            {
                throw new ToDoListException("There are no items in the to do list.");
            }
            _toDoList.Dequeue();
        }

        public string Get()
        {
            if (_toDoList.Count == 0)
            {
                throw new ToDoListException("There are no items in the to do list.");
            }
            return _toDoList.Peek();
        }
    }
}
