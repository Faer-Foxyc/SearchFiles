using SearchFiles.Classes;
using System;
using System.Collections.Generic;


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

            Console.ReadLine();
        }

        public static void CheckNumber(string _numb) // обрабатываем ввод, выполняем действия согласно меню
        {
            switch (_numb)
            {
                case "1":
                    FilesOutput();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    break;
            }
        }

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
        /// _MyDirectory - путь где искать файлы
        /// _Extension - расширение файлов
        /// Метод для введения данных
        /// </summary>
        public static void FilesOutput()
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
            List<String> _files = _filesHandling.GetFiles();
            int _numb = 0;

            foreach (var _file in _files)
            {
                _numb++;
                Console.WriteLine($"{_numb}) {_file}");
            }
        }
    }
}
