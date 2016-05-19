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
            throw new NotImplementedException();
        }

        public string Get()
        {
            return _toDoList.Peek();
        }
    }
}
