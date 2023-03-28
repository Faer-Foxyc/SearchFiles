using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace ConsoleApp3
{
    internal class _FileInfo
    {
        public string _Extension { get; set; }
        public string _FileName { get; set; } = string.Empty;   
        public long _FileSize { get; set; }

        public void GetFiles(string _Directory, string _Extension)
        {
            DirectoryInfo directory= new DirectoryInfo(_Directory);

            if (directory.Exists)
            {
                // Делаем обход папки
                foreach (FileInfo file in directory.GetFiles())
                {
                    
                    _FileName = file.Name;      // Получаем название файла
                    _FileSize = file.Length;

                    // Проверям, есть ли подстрока в названии файла
                    if (file.Extension == _Extension)
                    {
                        Console.WriteLine("File Name: {0}, File Size: {1}", _FileName, _FileSize);
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
