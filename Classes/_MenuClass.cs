using System;
using System.Security.Cryptography.X509Certificates;

namespace SearchFiles.Classes
{
    internal class _MenuClass
    {
        public void _OutMenu()
        {
            int _numb = 0;

            Console.WriteLine();
            string[] _optionsMenu = { "Search files", "Delete files", "Read files", "Copy files" };
            foreach (var _option in _optionsMenu)
            {
                _numb++;
                Console.WriteLine($"\t{_numb}.{_option}");
            }
        }
    }
}
