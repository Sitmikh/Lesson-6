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
                char add = '2';
                char open = '1';
                do
                {
                    string note = String.Empty;

                    uint id = 1;
                    note += $"{id}#";
                    id++;

                    string dateTime = DateTime.Now.ToString();
                    note += $"{dateTime}#";

                    Console.WriteLine("Введите ФИО: ");
                    note += $"{Console.ReadLine()}#";

                    Console.WriteLine("Введите возраст: ");
                    note += $"{Console.ReadLine()}#";

                    Console.WriteLine("Введите рост: ");
                    note += $"{Console.ReadLine()}#";

                    Console.WriteLine("Введите дату рождение в формате ДД.ММ.ГГГГ: ");
                    note += $"{Console.ReadLine()}#";

                    Console.WriteLine("Введите место рождения(город): ");
                    note += $"город {Console.ReadLine()}\t";
                }
                while (char.ToLower(add) == '2');
            }
        }

        static void Reader()
        {
            using (StreamReader sr = new StreamReader("Cотрудники.txt", Encoding.Unicode))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('#');
                    Console.WriteLine($"{data[0],15}.{data[1],15}{data[2],15}{data[3],15}лет{data[4],15}см.{data[5],15}г.р.{data[6],15}");
                }
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
