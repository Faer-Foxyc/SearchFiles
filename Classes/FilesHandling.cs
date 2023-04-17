using System;
using System.Collections.Generic;
using System.IO;

namespace SearchFiles.Classes
{
    internal class FilesHandling
    {
        public static string _path { get; set; }
        public static string _extension { get; set; }
        public FilesHandling(string _pathUser, string _extensionUser)
        {
            _path = _pathUser;
            _extension = _extensionUser;
        }

        public void Test()
        {
            Console.WriteLine();
        }

        public  List<String> GetFiles()
        {
            var _files = new List<String>();
            DirectoryInfo _directory = new DirectoryInfo(_path);
            if (_directory.Exists)
            {
                foreach (FileInfo _file in _directory.GetFiles())
                {
                    if (_file.Extension == _extension)
                    {
                        _files.Add($"{_file.Name}, Data create: {_file.CreationTime}, File size: {_file.Length}");
                    }
                }
            }
            return _files; 
        }
    }
}
