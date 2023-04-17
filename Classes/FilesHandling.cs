using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFiles.Classes
{
    internal class FilesHandling
    {
        public static string _path { get; set; }
        public static string _extension { get; set; }
        public FilesHandling(string _pathUser, string _extensionUser)
        {
            _pathUser = _path;
            _extensionUser = _extension;
        }
        public List<String> GetFiles(string _userPath, string _userExtension)
        {
            var _files = new List<String>();
            DirectoryInfo _directory = new DirectoryInfo(_userPath);
            if (_directory.Exists)
            {
                foreach (FileInfo _file in _directory.GetFiles())
                {
                    if (_file.Extension == _userExtension)
                    {
                        _files.Add($"{_file.Name}, Data create: {_file.CreationTime}, File size: {_file.Length}");
                    }
                }
            }

            return _files; 
        }
    }
}
