using OOP_Lab5;
using System;
using System.Numerics;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace OOP_Lab5
{

    class Program
    {
            static void Main(string[] args)
            {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
                {
                Console.WriteLine("=== Виберіть дію ===");
                    Console.WriteLine("1 - Робота з дробами (MyFrac)");
                    Console.WriteLine("2 - Робота з комплексними числами (MyComplex)");
                    Console.WriteLine("3 - Виконати unit-тести");
                    Console.WriteLine("0 - Вийти з програми");
                    Console.Write("Ваш вибір: ");

                    string input = Console.ReadLine();
                    Console.WriteLine();

                    switch (input)
                    {
                        case "1":
                            FracMenu();
                            break;
                        case "2":
                            ComplexMenu();
                            break;
                        case "3":
                            UnitTests.RunAllTests();
                            break;
                        case "0":
                           Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Невірний вибір, спробуйте ще раз.");
                            break;
                    }

                    Console.WriteLine();
                
                }
            }

            static void FracMenu()
            {
                Console.WriteLine("=== Введіть два дроби ===");

                Console.Write("Чисельник першого дробу: ");
                BigInteger nom1 = BigInteger.Parse(Console.ReadLine());
                Console.Write("Знаменник першого дробу: ");
                BigInteger den1 = BigInteger.Parse(Console.ReadLine());

                Console.Write("Чисельник другого дробу: ");
                BigInteger nom2 = BigInteger.Parse(Console.ReadLine());
                Console.Write("Знаменник другого дробу: ");
                BigInteger den2 = BigInteger.Parse(Console.ReadLine());

                MyFrac f1 = new MyFrac(nom1, den1);
                MyFrac f2 = new MyFrac(nom2, den2);

                Console.WriteLine("\nРезультати:");
                Console.WriteLine("a + b = " + f1.Add(f2));
                Console.WriteLine("a - b = " + f1.Subtract(f2));
                Console.WriteLine("a * b = " + f1.Multiply(f2));

                try
                {
                    Console.WriteLine("a / b = " + f1.Divide(f2));
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Помилка: ділення на нуль!");
                }
            }

            static void ComplexMenu()
            {
                Console.WriteLine("=== Введіть два комплексних числа ===");

                Console.Write("Дійсна частина першого числа: ");
                double re1 = double.Parse(Console.ReadLine());
                Console.Write("Уявна частина першого числа: ");
                double im1 = double.Parse(Console.ReadLine());

                Console.Write("Дійсна частина другого числа: ");
                double re2 = double.Parse(Console.ReadLine());
                Console.Write("Уявна частина другого числа: ");
                double im2 = double.Parse(Console.ReadLine());

                MyComplex c1 = new MyComplex(re1, im1);
                MyComplex c2 = new MyComplex(re2, im2);

                Console.WriteLine("\nРезультати:");
                Console.WriteLine("a + b = " + c1.Add(c2));
                Console.WriteLine("a - b = " + c1.Subtract(c2));
                Console.WriteLine("a * b = " + c1.Multiply(c2));

                try
                {
                    Console.WriteLine("a / b = " + c1.Divide(c2));
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Помилка: ділення на нуль!");
                }
            }
        }
    }

