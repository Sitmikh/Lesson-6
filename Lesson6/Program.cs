using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson6
{
    internal class Program
    {
        /// <summary>
        /// Метод для создания/заполнения файла
        /// </summary>
        /// <param name="id">первое число</param>
        /// <returns></returns>
        static uint Writer(uint id)
        {
            using (StreamWriter sw = new StreamWriter("Cотрудники.txt", true, Encoding.Unicode))
            {
                    string line = String.Empty;
                    
                    line += $"{id}#";

                    string dateTime = DateTime.Now.ToString();
                    line += $"{dateTime}#";

                    Console.Write("Введите ФИО: ");
                    line += $"{Console.ReadLine()}#";

                    Console.Write("Введите возраст: ");
                    line += $"{Console.ReadLine()}#";

                    Console.Write("Введите рост: ");
                    line += $"{Console.ReadLine()}#";

                    Console.Write("Введите дату рождение в формате ДД.ММ.ГГГГ: ");
                    line += $"{Console.ReadLine()}#";

                    Console.Write("Введите место рождения(город): ");
                    line += $"город {Console.ReadLine()}";
                    
                    sw.WriteLine(line);
                   
                    return id;
            }
        }
        /// <summary>
        /// Метод для считывания из файла
        /// </summary>
        static void Reader()
        {
            using (StreamReader sr = new StreamReader("Cотрудники.txt", Encoding.Unicode))
            {
                string line = sr.ReadToEnd();
                string[] data = line.Split('#','\r','\n');
                if (line != null)
                {
                    foreach (var word in line)
                    {
                        Console.Write(word);
                    }    
                }
                else
                {
                    Console.WriteLine("Файл не создан/пустой. Нажмите 2 для создания файла и внесения в нее первой записи");
                }
                
            }
        }

        static void Main(string[] args)
        {
            uint id = 1;
            string key;
            
            while (true)
            {
                Console.WriteLine("\tНажмите 1, чтобы отобразить список. Нажмите 2, чтобы внести новые данные. Нажмите 0 для выхода.");
                key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        Reader(); break;
                    case "2":
                        
                        Writer(id); id++; break;
                    case "0":
                        System.Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
