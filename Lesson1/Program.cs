using System;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Математическая программа.";
            Console.WriteLine("Вас привествует математическая программа.\nПожалуйста введите целое положительное число: ");

            int number = Int32.Parse(Console.ReadLine());
            if (number <= 0)
            {
                Console.WriteLine("Некорректное число.\nВведите число больше 0: ");
                number = Int32.Parse(Console.ReadLine());
            }


            bool f = true;
            while (f)
            {
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("1 ------> Факториал числа: " + number);
                Console.WriteLine("2 ------> Сумма от 1 до " + number + " равна: ");
                Console.WriteLine("3 ------> Максимальное чётное число меньше " + number + " равно: ");
                Console.WriteLine("0 ------> Выход из приложения");
                Console.WriteLine("----------------------------------------------------------------");

                Console.Write("Введите номер: ");

                int choose = int.Parse(Console.ReadLine());

                switch (choose)
                {

                    case 0:
                        Console.WriteLine("Завершение работы приложения...");
                        f = false;
                        break;

                    case 1:
                        Console.Title = ($"Факториал числа {number}");
                        Factorial(number);
                        break;

                    case 2:
                        Console.Title = ($"Сумма чисел от 1 до {number}");
                        Summa(number);
                        break;

                    case 3:
                        Console.Title = ($"Максимальное чётное число меньше {number}");
                        MaximumEven(number);
                        break;

                    default:
                        Console.WriteLine("Некорректный выбор задачи.\nПовторите попытку ввода.\n");
                        break;
                }
            }
        }

            private static void Factorial(int choose)
            {
                int a = 1;
                for (int i = 1; i <= choose; i++)
                    a = a * i;
                Console.WriteLine($"Факториал равен: {a}");
            }
            
            private static void Summa(int choose)
            {
                int a = 0;
                for (int i = 1; i <= choose; i++)
                    a = a + i;
                Console.WriteLine($"Сумма от 1 до {choose} равна : {a}");
            }

            private static void MaximumEven(int choose)
            {
                int a = 0;
                for (int i = 1; i < choose; i++)
                {
                    if(i % 2 == 0)
                    {
                        a = i;
                    }
                }
                Console.WriteLine($"Максимальное чётное число меньше {choose} это {a}");
            }
    }
}