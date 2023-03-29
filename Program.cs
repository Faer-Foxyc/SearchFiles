using System;


namespace SearchFiles
{
    internal class Program
    {
        static void Main(string[] args)
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

            _FileInfo _File = new _FileInfo();
            _File.GetFiles(_MyDirecTory, _Extension);
            
            Console.ReadLine();
        }
    }
}
