using System;
using System.IO;
using System.Text;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fstream = new FileStream(@"C:\MyFiles\text.txt", FileMode.Open))
            {
                byte[] array = new byte[fstream.Length]; // считываем данные из файла в байты
                fstream.Read(array, 0, array.Length);  // превращаем байты в строку
                string textFromFile = Encoding.UTF8.GetString(array); // конвертируем строковое представление байтов в привычную строку

                Console.WriteLine(textFromFile); // тестируем
            }

            Console.ReadKey();
        }
    }
}
