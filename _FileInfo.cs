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

        public void GetFiles(string _Directory, string _Extension)
        {
            DirectoryInfo directory= new DirectoryInfo(_Directory);

            if (directory.Exists)
            {
                // Делаем обход папки
                foreach (FileInfo file in directory.GetFiles())
                {
                    
                    _FileName = file.Name;     
                    _FileSize = file.Length;
                    _LastWriteDate = file.LastWriteTime;

                    // Проверям, на совпадение с расширением
                    if (file.Extension == _Extension)
                    {
                        Console.WriteLine("File Name: {0}, File Size: {1}, Last write time: {2}", _FileName, _FileSize, _LastWriteDate);
                    }

                }
            }
            else
            {
                Console.WriteLine("Directory is not found");
            }

        }

    }
}
