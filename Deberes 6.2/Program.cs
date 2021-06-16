using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Deberes_6._2
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Введите путь в каталог:");
            string catalog = Console.ReadLine();
            if (catalog.Length == 0)
                catalog = "C:\\Users\\usuario\\Downloads\\Test";
            Console.Write("Введите маску для файлов: ");
            string Mask = Console.ReadLine();
            if (Mask.Length == 0)
                Mask = "test.txt";
            Console.WriteLine("Введите текст, который нужно заменить: ");
            string Text = Console.ReadLine();
            if (Text.Length == 0)
                Text = "text";
            Console.WriteLine("Введите текст для замены: ");
            string NewText = Console.ReadLine();
            if (NewText.Length == 0)
                NewText = "THIS IS TEXT!";
            DirectoryInfo di = new DirectoryInfo(catalog);
            if (catalog[catalog.Length - 1] != '\\')
                catalog += '\\';

            if (!di.Exists)
            {
                Console.WriteLine("Каталога с таким именем не существует или он не может быть обработан програмой");
                return;
            }
            Search(catalog, Mask, Text, NewText);
        }
        private static void Search(string catalog, string Mask, string Text, string NewText)
        {
            StreamReader sr = null;
            DirectoryInfo di = new DirectoryInfo(catalog);
            foreach (string Path in Directory.GetFiles(catalog, Mask, SearchOption.AllDirectories))
            {
                sr = new StreamReader(Path);
                Console.WriteLine("Поиск текста в " + Path);
                string Content = sr.ReadToEnd();
                string New = Content.Replace(Text, NewText);
                if (New==Content)
                    Console.WriteLine("В файле не найдено текста для замены");
                sr.Close();
                StreamWriter sw = new StreamWriter(Path, false, Encoding.Default);
                sw.Write(New);
                sw.Close();
            }
        }
    }
}
