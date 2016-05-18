﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ToDoFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var toDoEditor = new ToDoEditor();
            Write("Please enter the name of your To Do list: ");
            var ans = ReadLine();
            toDoEditor.Open(ans);
            if (toDoEditor.CurrentFile == "")
            {
                WriteLine(toDoEditor.Message);
            }
            ReadLine();
        }
    }
}
