using System;
using System.IO;


namespace SearchFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _answer = "";

            DataEntry();

            while (_answer != "No")
            {
                Console.WriteLine();
                Console.Write("You want Continue? Yes/No: ");
                _answer = Console.ReadLine();
                Console.WriteLine();

                Repit(_answer);
            }
            Console.ReadLine();
        }

        public static void Repit(string _answer) // проверяем ответ и выполняем действия
        {
            switch (_answer)
            {
                case "Yes":
                    DataEntry();
                    break;
                case "Y":
                    DataEntry();
                    break;
                case "yes":
                    DataEntry();
                    break;   
                case "no":
                    Environment.Exit(0);
                    break;
                case "No":
                    Environment.Exit(0);
                    break;
                default: Environment.Exit(0);
                    break;
            }
        }

        /// <summary>
        /// _MyDirectory - путь где искать файлы
        /// _Extension - расширение файлов
        /// Метод для введения данных
        /// </summary>
        public static void DataEntry()
        {
            string _MyDirecTory = string.Empty;
            while (_MyDirecTory == string.Empty) // просим Вводить Пока Не Заполнят
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

            _GetDirectory _FInfo = new _GetDirectory(_MyDirecTory, _Extension);
            _GetFiles(_FInfo.GetDirectory(), _FInfo._extension);
        }

        public static void _GetFiles(string _Directory, string _Extension) // метод для получения файлов
        {
            if (_Directory != "")
            {
                DirectoryInfo directory = new DirectoryInfo(_Directory);

                // Делаем обход папки
                foreach (FileInfo file in directory.GetFiles())
                {
                    // Проверям, на совпадение с расширением
                    if (file.Extension == _Extension)
                    {
                        Console.WriteLine($"File Name: {file.Name}, File Size: {file.Length}, Last write time: {file.LastWriteTime}");
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
