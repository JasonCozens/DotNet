using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoFile
{
    public class ToDoListPersistence : IToDoListPersistence
    {
        /// <summary>
        /// Need to consider handling exceptions here.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public IEnumerable<string> Open(string filename)
        {
            File.OpenText(filename);
            return new List<string>();
        }

        public void Save(IEnumerable<string> toDoList)
        {
            throw new NotImplementedException();
        }
    }
}
