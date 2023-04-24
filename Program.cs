using SearchFiles.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace SearchFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// меню -----------------------------------------------------------------------------------
            Menu();

            Console.Write("\n\nEnter number menu: ");
            string _number = Console.ReadLine(); // просим ввести цифру меню

            /// методы ---------------------------------------------------------------------------------

            CheckNumber(_number);

            /// конец ----------------------------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("Good bye");
            
            Thread.Sleep(1000);
            
        }
        /// <summary>
        /// проверка номера и запуск метода
        /// </summary>
        /// параметр который принимает число
        /// <param name="_numb"></param>
        public static void CheckNumber(string _numb) // обрабатываем ввод, выполняем действия согласно меню
        {
            switch (_numb)
            {
                case "1":
                    FilesOutput();
                    break;
                case "2":
                    DeleteFile();
                    break;
                case "3":
                    ReadFile();
                    break;
                case "4":
                    break;
                case "5":
                    WriteFile();
                    break;
            }
        }
        /// <summary>
        /// метод вывода меню
        /// </summary>
        public static void Menu()
        {
            Console.Write("___________Menu__________");
            Console.WriteLine();
            Console.WriteLine();
            _MenuClass _Menu = new _MenuClass();
            List<string> _optionsMenu = _Menu._OutMenu();
            int _count = 0;
            foreach (var _option in _optionsMenu)
            {
                _count++;
                Console.WriteLine($"    {_count}) {_option}");
            }
            Console.Write("_________________________");
        }
        /// <summary>
        /// метод вывода файла
        /// </summary>
        public static void FilesOutput() // вывод найденных файлов и немного информации
        {
            while (true)
            {
                string _myDirecTory = string.Empty;
                while (_myDirecTory == string.Empty) // просим Вводить Пока Не Заполнят
                {
                    Console.Write("\nEnter dirrectory for search:  ");
                    _myDirecTory = Console.ReadLine();
                }

                string _extension = string.Empty;
                while (_extension == string.Empty)
                {
                    Console.Write("Enter extension for search: ");
                    _extension = Console.ReadLine();
                }

                Console.WriteLine();

                FilesHandling _filesHandling = new FilesHandling(_myDirecTory, _extension);
                List<String> _files = _filesHandling.GetFiles(); // получаем список файлов
                int _numb = 0;

                if (_files != null)
                {
                    foreach (var _file in _files)
                    {
                        _numb++;
                        Console.WriteLine($"{_numb}) {_file}");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Directory and file not exists");
                }

                Console.WriteLine();
                Console.Write("You want continue? (Yes/No): ");

                if (Console.ReadLine().ToLower() == "no")
                {
                    break;
                }
            }
        }
        /// <summary>
        /// метод удаления файла
        /// </summary>
        public static void DeleteFile() // удаление файла
        {
            while (true) // бесконечный цикл, пока пользователь не введет - no
            {
                string _myDirecTory = string.Empty;
                while (_myDirecTory == string.Empty) // просим Вводить Пока Не Заполнят
                {
                    Console.Write("\nEnter dirrectory for search:  ");
                    _myDirecTory = Console.ReadLine();
                }

                Console.WriteLine();

                FilesHandling filesHandling = new FilesHandling(_myDirecTory, "");
                filesHandling.DeleteFile();

                Console.WriteLine();
                Console.Write("You want continue? (Yes/No): ");
                if (Console.ReadLine().ToLower() == "no")
                {
                    break;
                }
            }
        }
        /// <summary>
        /// метод для чтения файла
        /// </summary>
        public static void ReadFile() // прочитать файл
        {
            Console.WriteLine();
            Console.WriteLine("Hello i can read .txt files");

            while (true) // бесконечный цикл, пока пользователь не введет - no
            {
                string myDirecTory = string.Empty;
                while (myDirecTory == string.Empty) // просим Вводить Пока Не Заполнят
                {
                    Console.Write("\nEnter dirrectory for search:  ");
                    myDirecTory = Console.ReadLine();
                }

                Console.WriteLine();

                var lines = File.ReadAllLines(myDirecTory, Encoding.UTF8);
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }

                Console.WriteLine();
                Console.Write("You want continue? (Yes/No): ");
                if (Console.ReadLine().ToLower() == "no")
                {
                    break;
                }
            }
        }
        /// <summary>
        /// метод для записи в файл
        /// </summary>
        public static void WriteFile() 
        {
            Console.WriteLine();
            Console.WriteLine("Hello i can write .txt files");

            while (true) // бесконечный цикл, пока пользователь не введет - no
            {
                string myDirecTory = string.Empty;
                while (myDirecTory == string.Empty) // просим Вводить Пока Не Заполнят
                {
                    Console.Write("\nEnter dirrectory for search:  ");
                    myDirecTory = Console.ReadLine();
                }

                Console.WriteLine();

                Console.Write("Enter text: ");
                var text = Console.ReadLine();

                var file = new StreamWriter(myDirecTory, false, Encoding.UTF8);
                file.WriteLine(text);
                file.Close();

                Console.WriteLine();
                Console.Write("You want continue? (Yes/No): ");
                if (Console.ReadLine().ToLower() == "no")
                {
                    break;
                }
            }
        }
    }
}
