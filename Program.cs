using System;

namespace Program
{
  class Program
  {
    static void DoBlock_1()
    {
      System.Console.WriteLine("Дана послідовність з n цілих чисел. Знайти суму елементів з непарними номерами з цієї послідовності.");
      System.Console.Write("Введіть значення n: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int sum = 0;

      for (int i = 1; i <= n; i++)
      {
        int k = Convert.ToInt32(Console.ReadLine());
        if (i % 2 == 1)
        {
          sum += k;
        }
      }

      System.Console.WriteLine(sum);
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
        Console.WriteLine("Для виконання блоку 1 (варіант 5) введіть 1");
        Console.WriteLine("Для виконання блоку 2 (варіант 25 введіть 2");
        Console.WriteLine("Для виконання блоку 3 (варіант 62 введіть 3");
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
