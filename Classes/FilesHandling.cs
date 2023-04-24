using System;
using System.Collections.Generic;
using System.IO;

namespace SearchFiles.Classes
{
    internal class FilesHandling
    {
        public static string _path { get; set; }
        public static string _extension { get; set; }
        public FilesHandling(string _pathUser, string _extensionUser)
        {
            _path = _pathUser;
            _extension = _extensionUser;
        }

        /// <summary>
        /// метод формирует найденные файлы и передает в видет списка
        /// </summary>
        /// <returns></returns>
        public  List<String> GetFiles()
        {
            try
            {
                DirectoryInfo _directory = new DirectoryInfo(_path);
                if (_directory.Exists)
                {
                    var _files = new List<String>();
                    // получаем список файлов в директории
                    foreach (FileInfo _file in _directory.GetFiles())
                    {
                        if (_file.Extension == _extension) // если расширение заполнено
                        {
                            _files.Add($"{_file.Name}, Data create: {_file.CreationTime}, File size: {_file.Length}");
                        }
                        else if (_file.Extension == "") // если расширение не заполнено
                        {
                            _files.Add($"{_file.FullName}");
                        }
                    }
                    return _files;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        /// <summary>
        ///  Метод удаления файлов
        /// </summary>
        public void DeleteFile()
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(_path);
                if (directoryInfo.Exists)
                {
                    File.Delete(_path);
                    Console.WriteLine("File deleted");
                }
                else
                {
                    Console.WriteLine("Directory is not exist");
                }
                
            }
            catch (Exception e) // отловим ошибку, если в место директории введут пробелы или tab
            {
                Console.WriteLine(e.Message);
            }
        }
        private void ReadFile()
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(_path);
                if (directoryInfo.Exists)
                {

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
