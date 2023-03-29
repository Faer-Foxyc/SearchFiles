using System;
using System.IO;


namespace SearchFiles
{
    internal class _FileInfo
    {
        public string _Extension { get; set; }
        public string _FileName { get; set; } = string.Empty;   
        public long _FileSize { get; set; }
        public DateTime _LastWriteDate { get; set; }

        public string GetDirectory(string _Directory)
        {
            DirectoryInfo directory = new DirectoryInfo(_Directory);

            if (directory.Exists)
            {
                return _Directory;
            }
            else
            {
                return "Directory is not found";
            }

        }

    }
}
