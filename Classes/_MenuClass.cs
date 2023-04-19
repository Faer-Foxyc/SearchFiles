using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace SearchFiles.Classes
{
    internal class _MenuClass
    {      
        public List<string> _OutMenu() // метод класса
        {
            var _options = new List<string> { "Search files", "Delete file", "Read file", "Copy file", "Write file" };

            return _options;
        }
    }
}
