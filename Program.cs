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

            Console.Write("___________Menu__________");
            Console.WriteLine();
            _MenuClass _Menu = new _MenuClass();
            _Menu._OutMenu();
            Console.Write("_________________________");
            Console.Write("\n\nEnter number menu: ");
            string _number = Console.ReadLine(); // просим ввести цифру меню

            /// методы ---------------------------------------------------------------------------------

            ProcessInput(_number);
            
            /// конец ----------------------------------------------------------------------------------

            Console.ReadLine();
        }

        public static void ProcessInput(string _numb) // обрабатываем ввод, выполняем действия согласно меню
        {
            switch (_numb)
            {
                case "1":
                    DataEntry();
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

        /// <summary>
        /// _MyDirectory - путь где искать файлы
        /// _Extension - расширение файлов
        /// Метод для введения данных
        /// </summary>
        public static void DataEntry()
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
