using System;
using System.IO;

namespace SearchFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataEntry();
        }

        public static void DataEntry()
        {
            string _MyDirecTory = string.Empty;

            while (_MyDirecTory == string.Empty)
            {
                Console.Write("Enter dirrectory for search:  ");
                _MyDirecTory = Console.ReadLine();
            }

            string _Extension = string.Empty;

            while (_Extension == string.Empty)
            {
                Console.Write("Enter extension for search: ");
                _Extension = Console.ReadLine();
            }

            Console.WriteLine();

            _GetDirectory _FInfo = new _GetDirectory();

            _GetFiles(_FInfo.GetDirectory(_MyDirecTory), _Extension);

            Console.ReadLine();
        }


        public static void _GetFiles(string _Directory, string _Extension)
        {
            if (_Directory != "")
            {
                DirectoryInfo directory = new DirectoryInfo(_Directory);

                // Делаем обход папки
                foreach (FileInfo file in directory.GetFiles())
                {
                    string _FileName = file.Name;
                    long _FileSize = file.Length;
                    DateTime _LastWriteDate = file.LastWriteTime;

                    // Проверям, на совпадение с расширением
                    if (file.Extension == _Extension)
                    {
                        Console.WriteLine($"File Name: {_FileName}, File Size: {_FileSize}, Last write time: {_LastWriteDate}");
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
