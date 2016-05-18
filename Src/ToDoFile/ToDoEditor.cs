using System;
using System.IO;

namespace ToDoFile
{
    public class ToDoEditor
    {
        public ToDoEditor()
        {
            CurrentFile = "";
        }

        public int Count {
            get
            {
                return 0;
            }
        }

        public string CurrentFile { get; private set; }

        public void Open(string toDoList)
        {
            File.OpenText(toDoList);
        }
    }
}