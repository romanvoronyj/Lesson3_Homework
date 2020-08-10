using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_HW_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть будь-яке число від 0 до 100: ");
            int number;
            int.TryParse(Console.ReadLine(), out number);

            if (number >= 0 && number <= 14)
            {
                Console.WriteLine("Ваше число належить до діапазону 1-14.");
            }

            else if (number >= 15 && number <= 35)
            {
                Console.WriteLine("Ваше число належить до діапазону 15-35.");
            }
            else if (number >= 36 && number <= 50)
            {
                Console.WriteLine("Ваше число належить до діапазону 36-50.");
            }
            else if (number >= 51 && number <= 100)
            {
                Console.WriteLine("Ваше число належить до діапазону 51-100.");
            }
            //else if (number >= 101 && number <= 0)  чому не працює?
            //{
                //Console.WriteLine("Ваше число не належить до жодного з діапазонів");
            //}
            else if (number >= 101)
            {
                Console.WriteLine("Ваше число не належить до жодного з діапазонів!");
            }
            else if (number <= 0)
            {
                Console.WriteLine("Ваше число не належить до жодного з діапазонів!");
            }
            Console.ReadKey();
        }
    }
}