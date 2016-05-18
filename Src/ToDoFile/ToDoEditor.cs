using System;
using System.IO;

namespace ToDoFile
{
    public class ToDoEditor
    {
        public ToDoEditor()
        {
        }

        public int Count {
            get
            {
                return 0;
            }
        }

        public void Open(string toDoList)
        {
            File.OpenText(toDoList);
        }
    }
}