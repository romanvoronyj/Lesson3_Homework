using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_HW_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть перше число:");
            string a = Console.ReadLine();
            int operand1 = Convert.ToInt32(a);
            Console.WriteLine("Введіть друге число:");
            string b = Console.ReadLine();
            int operand2 = Convert.ToInt32(b);
            Console.Write("Виконайте будь-яку арифметичну дію з числами:");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    {
                        int add = operand1 + operand2;
                        Console.WriteLine(add);
                        break;
                    }
                case "-":
                    {
                        int diff = operand1 - operand2;
                        Console.WriteLine(diff);
                        break;
                    }
                case "*":
                    {
                        int mult= (operand1 * operand2);
                        Console.WriteLine(mult);
                        break;
                    }
                case "/":
                    {
                        float div = (float)operand1 / operand2;
                        Console.WriteLine(div);
                        break;
                    }
                case "%":
                    {
                        int remain = operand1 / operand2;
                        Console.WriteLine(remain);
                        break;
                    }
                case "/0":
                    {
                        int zero = operand1 / 0;
                        Console.WriteLine("Ділення на 0 заборонено.");
                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}


