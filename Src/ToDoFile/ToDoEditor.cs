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

        public string Message { get; set; }

        public void Open(string toDoList)
        {
            try
            {
                File.OpenText(toDoList);
            }
            catch (FileNotFoundException ex)
            {
                Message = string.Format("Could not open file {0}", ex.FileName);
            }
        }
    }
}