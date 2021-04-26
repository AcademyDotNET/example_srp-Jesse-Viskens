using System;
using System.Collections.Generic;
using System.Text;

namespace Werknemer
{
    class FileLogger
    {
        public void Log(string e)
        {
            System.IO.File.WriteAllText(@"C:\Error.txt", e.ToString());
        }
    }
}
