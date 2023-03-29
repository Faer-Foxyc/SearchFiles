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
            Console.Write("Enter directory for search: ");
            string _MyDirecTory = Console.ReadLine();

            while (_MyDirecTory == string.Empty)
            {
                Console.Write("Enter dirrectory for search:  ");
                _MyDirecTory = Console.ReadLine();
            }

            Console.Write("Enter extension for search: ");
            string _Extension = Console.ReadLine();

            while (_Extension == string.Empty)
            {
                Console.Write("Enter extension for search: ");
                _Extension = Console.ReadLine();
            }

            Console.WriteLine();

            _FileInfo _FInfo = new _FileInfo();

            _GetFiles(_FInfo.GetDirectory(_MyDirecTory), _Extension);

            Console.ReadLine();
        }


        public static void _GetFiles(string _Directory, string _Extension)
        {
            DirectoryInfo directory = new DirectoryInfo(_Directory);

            if (directory.Exists)
            {
                // Делаем обход папки
                foreach (FileInfo file in directory.GetFiles())
                {
                    string _FileName = file.Name;
                    long _FileSize = file.Length;
                    DateTime _LastWriteDate = file.LastWriteTime;

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
