using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Helpers
{
    public class Files
    {
        public static string TasksFilePath = Path.Combine(FileSystem.Current.AppDataDirectory, "zadania");
    }
}
