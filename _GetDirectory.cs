using System;
using System.IO;


namespace SearchFiles
{
    internal class _GetDirectory
    {
        public string _path;
        public string _extension;

        public string GetDirectory() // проверяем существует директория или нет
        {
            DirectoryInfo directory = new DirectoryInfo(_path);

            if (directory.Exists)
            {
                return _path;
            }
            else
            {
                return string.Empty;
            }
        }
        public _GetDirectory(string _Patch, string _Extension) 
        {
            _path = _Patch;
            _extension = _Extension;
        }
    }
}
