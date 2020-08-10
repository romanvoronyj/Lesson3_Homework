using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_HW_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Доступний для перекладу список слів:\nметро \nгори \nдорога \nтеатр \nапельсин \nквартира \nворота \nкорабель \nчовен \nавтобус ");
            Console.Write("Введіть слово, яке необхілно перекласти: ");
            string word=Console.ReadLine();
            switch (word)
            {
                case "метро":
                    Console.WriteLine("\nsuburb");
                    break;
                case "гори":
                    Console.WriteLine("\nmountains");
                    break;
                case "дорога":
                    Console.WriteLine("\nroad");
                    break;
                case "театр":
                    Console.WriteLine("\ntheatre");
                    break;
                case "апельсин":
                    Console.WriteLine("\norange");
                    break;
                case "квартира":
                    Console.WriteLine("\nflat");
                    break;
                case "ворота":
                    Console.WriteLine("\ngate");
                    break;
                case "корабель":
                    Console.WriteLine("\nship");
                    break;
                case "човен":
                    Console.WriteLine("\nboat");
                    break;
                case "автобус":
                    Console.WriteLine("\nbus");
                    break;
                default:
                    Console.WriteLine("Введеного Вами слова не знайдено.Оберіть, будь ласка, слово, доступне у списку");
                    break;
            }
            Console.ReadKey();
        }
    }
}
