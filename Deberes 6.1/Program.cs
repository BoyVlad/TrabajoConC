using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpApplication.SearchInFiles
{
    class SearchDirectory
    {
        static void Main()
        {

            Console.WriteLine("Введите путь в каталог:");
            string catalog = Console.ReadLine();
            Console.Write("Введите маску для файлов: ");
            string Mask = Console.ReadLine();

            if (catalog[catalog.Length - 1] != '\\')
                catalog += '\\';

            DirectoryInfo di = new DirectoryInfo(catalog);
            if (!di.Exists)
            {
                Console.WriteLine("Каталога с таким именем не существует или он не может быть обработан програмой");
                return;
            }

            Search(catalog, Mask, catalog + "ResultSearch.txt");
        }
        private static void Search(string catalog, string Mask, string ResultSearch)
        {
            StreamWriter sw = new StreamWriter(ResultSearch, true);

            try
            {
                foreach (string Path in Directory.GetFiles(catalog, Mask, SearchOption.AllDirectories))
                {
                    Console.WriteLine(Path);
                    DateTime lastred = File.GetLastWriteTime(Path);
                    sw.WriteLine(Path + " в последний раз редактирован " + lastred);    
                }
                sw.Close();
            }
            catch
            {
                Console.WriteLine("Ошибка при работе с {0}", catalog);
                sw.Close();
                return;
            }
        }
    }
}

