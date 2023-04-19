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

        public  List<String> GetFiles()
        {
            try
            {
                DirectoryInfo _directory = new DirectoryInfo(_path);
                if (_directory.Exists)
                {
                    var _files = new List<String>();
                    // получаем список файлов в директории
                    foreach (FileInfo _file in _directory.GetFiles())
                    {
                        if (_file.Extension == _extension | _extension == "")
                        {
                            _files.Add($"{_file.Name}, Data create: {_file.CreationTime}, File size: {_file.Length}");
                        }
                    }
                    return _files;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        public void DeleteFile()
        {
            try
            {
                File.Delete(_path);
                Console.WriteLine("File deleted");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
