﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoFile
{
    public class ToDoListException : Exception
    {
        public ToDoListException(string message) : base(message)
        {
        }
    }
}
