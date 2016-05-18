using System;
using System.Collections.Generic;
using System.IO;

namespace ToDoFile
{
    public class ToDoEditor
    {
        IToDoListPersistence _persistence;
        readonly List<string> _toDoList = new List<string>();

        public ToDoEditor(IToDoListPersistence persistence)
        {
            if (persistence == null) throw new ArgumentNullException("persistence");
            _persistence = persistence;
            CurrentFile = "";
        }

        public int Count {
            get
            {
                return _toDoList.Count;
            }
        }

        public string CurrentFile { get; private set; }

        public string Message { get; set; }

        public void Add(string description)
        {
            _toDoList.Add(description);
        }
    }
}