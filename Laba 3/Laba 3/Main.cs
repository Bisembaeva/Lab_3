using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3
{
    public static class Main
    {
        public static void Start()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Главное меню ===");
                Console.WriteLine("1. Дано натуральное . Вычислить 1*2 + 2*3*4 + ... + n* (n+1) * ... *(2n)");
                Console.WriteLine("2. Найти значение ‼. Если n – четное, то n!! - 2*4*6*...*n, если – нечетное, то n!! = 1*3*5*...*n");
                Console.WriteLine("3. Найти все числа Армстронга, принадлежащие заданному отрезку [a, b]. Числом Армстронга является число, сумма кубов цифр которого совпадает с самим числом. Например, 153 = 12 + 52 + 32.");
                Console.WriteLine("4. Найти все пары дружественных чисел, принадлежащих отрезку [a, b]. Два числа называются дружественными, если они равны сумме делителей друг друга (исключая сами числа). Например, дружественными числами являются числа 220 и 284.");
                Console.WriteLine("5. Вычислить xn");
                Console.WriteLine("6. Вывести все номера счастливых билетов. Номер билета состоит из 6 цифр. Счастливым считается билет, сумма первых трех цифр записи которого совпадает с суммой трех последних цифр записи");
                Console.WriteLine("7. Найти n-е по порядку число Фибоначчи. ");
                Console.WriteLine("8. Вычислить по схеме Горнера следующую функцию: y=x^10+2x^9+3x^8+...+10x+11");
                Console.WriteLine("9. Выход");
                Console.Write("Выберите пункт: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Ошибка ввода! Введите число от 1 до 4.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6();
                        break;
                    case 7:
                        Task7();
                        break;
                    case 8:
                        Task8();
                        break;
                    case 9:
                        Console.WriteLine("9. Выход из программы...");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный пункт меню!");
                        Thread.Sleep(1000);
                        Start();
                        break;
                }

                Console.WriteLine();
            }
            while (choice != 9);
        }
        private static void PressToContinue()
        {
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey();
        }
        private static void Task1()
        {
            Console.Clear();
            Console.WriteLine("1. Дано натуральное . Вычислить 1*2 + 2*3*4 + ... + n* (n+1) * ... *(2n)");
            int number = 4;
            Console.WriteLine($"Данно: {number}. Результат: {CustomMath.Task1(number)}");

            PressToContinue();
        }
        private static void Task2()
        {
            Console.Clear();
            Console.WriteLine("2. Найти значение ‼. Если n – четное, то n!! - 2*4*6*...*n, если – нечетное, то n!! = 1*3*5*...*n");
            int number = 8;
            Console.WriteLine($"Данно: {number}. Результат: {CustomMath.Task2(number)}");

            PressToContinue();
        }
        private static void Task3()
        {
            Console.Clear();
            Console.WriteLine("3. Найти все числа Армстронга, принадлежащие заданному отрезку [a, b]. Числом Армстронга является число, сумма кубов цифр которого совпадает с самим числом. Например, 153 = 12 + 52 + 32.");
            int a = 100;
            int b = 1000;
            Console.WriteLine($"Отрезок от {a} до {b}");
            Console.Write("Все числа Армстронга: ");
            foreach (var item in CustomMath.Task3(a, b))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            PressToContinue();
        }
        private static void Task4()
        {
            Console.Clear();
            Console.WriteLine("4. Найти все пары дружественных чисел, принадлежащих отрезку [a, b]. Два числа называются дружественными, если они равны сумме делителей друг друга (исключая сами числа). Например, дружественными числами являются числа 220 и 284.");

            int a = 1;
            int b = 10000;
            Console.WriteLine("Все дружественные числа: ");
            foreach (var item in CustomMath.Task4(a, b))
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
            PressToContinue();
        }
        private static void Task5()
        {
            Console.Clear();
            Console.WriteLine("5. Вычислить x^n");
            int x = 5;
            int n = 3;
            Console.WriteLine($"Число {x} в степени {n} = {CustomMath.Task5(x, n)}");

            PressToContinue();
        }
        private static void Task6()
        {
            Console.Clear();
            Console.WriteLine("6. Вывести все номера счастливых билетов. Номер билета состоит из 6 цифр. Счастливым считается билет, сумма первых трех цифр записи которого совпадает с суммой трех последних цифр записи");

            CustomMath.Task6();

            PressToContinue();
        }
        private static void Task7()
        {
            Console.Clear();
            Console.WriteLine("7. Найти n-е по порядку число Фибоначчи. ");
            int number = 10;
            Console.WriteLine($"n по порядку числа Фибоначчи от {number} = {CustomMath.Task7(number)}");

            PressToContinue();
        }
        private static void Task8()
        {
            Console.Clear();
            Console.WriteLine("8. Вычислить по схеме Горнера следующую функцию: y=x^10+2x^9+3x^8+...+10x+11");
            int number = 10;
            Console.WriteLine($"Число {number} по схеме Горнера = {CustomMath.Task8(number)}");

            PressToContinue();
        }
    }
}
