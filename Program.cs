using System;

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
      System.Console.WriteLine("Дана послідовність цілих чисел, за якою слідує 0. Знайти номер мінімального елементу в цій послідовності.");

      int min = int.MaxValue;
      int minIndex = 0;
      int currentIndex = 1;
      int i;

      do
      {
        i = Convert.ToInt32(Console.ReadLine());
        if (i == 0)
        {
          break;
        }
        if (i < min)
        {
          min = i;
          minIndex = currentIndex;
        }



        currentIndex++;
      } while (i != 0);

      System.Console.WriteLine("Номер мінімального елемента: " + minIndex);
    }


    static void DoBlock_3()
    {
      System.Console.WriteLine("S = sin(x + cos(2x + sin(3x + cos(4x + sin(5x + cos(6x +...)...) (до sin(nx) чи cos(nx) включно, sin(nx) чи cos(nx) залежить від парності n);");
      System.Console.Write("Введіть n: ");
      int n = Convert.ToInt32(Console.ReadLine());
      System.Console.Write("Введіть x: ");
      int x = Convert.ToInt32(Console.ReadLine());
      double temp;

      if (n % 2 == 0)
      {
        temp = (n - 1) * x + Math.Cos(n * x);

      }
      else
      {
        temp = (n - 1) * x + Math.Sin(n * x);
      }
      for (int i = n - 1; i > 0; i--)
      {
        if (i % 2 == 0)
        {

          temp += Math.Cos((n - 2) * x + temp);
        }
        else
        {
          temp += Math.Sin((n - 2) * x + temp);
        }
      }


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
