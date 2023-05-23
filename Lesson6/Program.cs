using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    internal class Program
    {

        static void Writer()
        {
            using (StreamWriter sw = new StreamWriter("Cотрудники.txt", true, Encoding.Unicode))
            {
                    string note = String.Empty;

                    uint id = 1;
                    note += $"{id}#";
                    id++;

                    string dateTime = DateTime.Now.ToString();
                    note += $"{dateTime}#";

                    Console.Write("Введите ФИО: ");
                    note += $"{Console.ReadLine()}#";

                    Console.Write("Введите возраст: ");
                    note += $"{Console.ReadLine()}#";

                    Console.Write("Введите рост: ");
                    note += $"{Console.ReadLine()}#";

                    Console.Write("Введите дату рождение в формате ДД.ММ.ГГГГ: ");
                    note += $"{Console.ReadLine()}#";

                    Console.Write("Введите место рождения(город): ");
                    note += $"город {Console.ReadLine()}\t";
                    
                    sw.WriteLine(note);
            }
        }

        static void Reader()
        {
            using (StreamReader sr = new StreamReader("Cотрудники.txt", Encoding.Unicode))
            {
                string line;
                if ((line = sr.ReadLine()) != null)
                {
                    while ((line != null))
                    {
                        string[] data = line.Split('#');
                        Console.WriteLine($"{data[0],15}.{data[1],15}{data[2],15}{data[3],15}лет{data[4],15}см.{data[5],15}г.р.{data[6],15}");
                    }
                }
                else
                {
                    Console.WriteLine("Файл не создан/пустой. Нажмите 2 для создания файла и внесения в нее первой записи");
                }
                //Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
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
                        Writer(); break;
                    case "0":
                        break;
                }
            }
           // char.ToLower(add) == '1'
        }
    }
}
