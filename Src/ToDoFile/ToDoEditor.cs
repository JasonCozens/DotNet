using System;
using System.IO;

namespace ToDoFile
{
    public class ToDoEditor
    {
        IToDoListPersistence _persistence;

        public ToDoEditor(IToDoListPersistence persistence)
        {
            if (persistence == null) throw new ArgumentNullException("persistence");
            _persistence = persistence;
            CurrentFile = "";
        }

        public int Count {
            get
            {
                return 0;
            }
        }

        public string CurrentFile { get; private set; }

        public string Message { get; set; }

        public void Add(string description)
        {

        }
    }
}