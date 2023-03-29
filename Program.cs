using System;


namespace SearchFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter dirrectory for search: "); // Добавить бесконечный цикл для ввода директории, как только ввел выходим
            string _MyDirecTory = Console.ReadLine();
            if (_MyDirecTory == string.Empty)
            {
                Console.WriteLine("Enter dirrectory for search:  ");
                _MyDirecTory= Console.ReadLine();
            }

            Console.Write("Enter extension for search: ");
            string _Extension = Console.ReadLine();
            if (_Extension == string.Empty)
            {
                Console.Write("Enter extension for search: ");
                _Extension = Console.ReadLine();
            }

            Console.WriteLine();

            _FileInfo _File = new _FileInfo();
            _File.GetFiles(_MyDirecTory, _Extension);
            
            Console.ReadLine();
        }
    }
}
