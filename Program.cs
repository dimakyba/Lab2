using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DraftForLab2
{
    class Program
    {
        static void DoBlock_1()
        {
            // add your code here...
        }

        static void DoBlock_2()
        {
            // add your code here...
        }

        static void DoBlock_3()
        {
            // add your code here...
        }

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Для виконання блоку 1 (варіант ...) введіть 1");
                Console.WriteLine("Для виконання блоку 2 (варіант ...) введіть 2");
                Console.WriteLine("Для виконання блоку 3 (варіант ...) введіть 3");
                Console.WriteLine("Для виходу з програми введіть 0");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Виконую блок 1");
                        DoBlock_1();
                        break;
                    case 2:
                        Console.WriteLine("Виконую блок 2");
                        DoBlock_2();
                        break;
                    case 3:
                        Console.WriteLine("Виконую блок 3");
                        DoBlock_3();
                        break;
                    case 0:
                        Console.WriteLine("Зараз завершимо, тільки натисніть будь ласка ще раз Enter");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Команда ``{0}'' не розпізнана. Зробіь, будь ласка, вибір із 1, 2, 3, 0.", choice);
                        break;
                }
            } while (choice != 0);
        }
    }
}
