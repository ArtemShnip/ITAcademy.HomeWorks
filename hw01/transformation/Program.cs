using System;
using System.IO;

namespace transformation
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                1 Чтение файла по пути "C:\it-academy\files\image.txt"
                2 Читаем файл и возвращает строку
                3 Разбиваем строку по пробелу и дабавляем в массив
                4 Создаем пустой байтовый массив с длинной стринговова массива -1
                5 Освобождает все ресурсы, используемые объектом TextReader 
                6 Создаем цикл,от до конца массива с шагом 1
                7 Конвертация из стринга в байт и присвоение значения переменной
                8 Значение переменной добовляем в массив
                9 Создание файла, с помощью массива байтов и сохранение по указаному пути
            */

            StreamReader textReader = new StreamReader(@"C:\project\files\image.txt", true);
            string textReaderResult = textReader.ReadToEnd();
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
            textReader.Dispose();

            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }
            File.WriteAllBytes(@"C:\project\files\image.png", imageBytes);

        }
    }
}
