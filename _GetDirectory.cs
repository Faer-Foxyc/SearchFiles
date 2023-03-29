using System;
using System.IO;


namespace SearchFiles
{
    internal class _GetDirectory
    {
        public string GetDirectory(string _Directory)
        {
            DirectoryInfo directory = new DirectoryInfo(_Directory);

            if (directory.Exists)
            {
                return _Directory;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
