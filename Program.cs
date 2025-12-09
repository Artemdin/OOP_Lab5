using System;
using System.Numerics;

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
                Console.WriteLine("1 - Тест формули (a+b)^2 на дробах");
                Console.WriteLine("2 - Тест формули (a+b)^2 на комплексних");
                Console.WriteLine("3 - Виконати unit-тести");
                Console.WriteLine("0 - Вийти");
                Console.Write("Ваш вибір: ");

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        FracTest();
                        break;

                    case "2":
                        ComplexTest();
                        break;
                   
                    case "3":
                        UnitTests.RunAllTests();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Невірний вибір!");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void FracTest()
        {
            Console.WriteLine("=== Введіть два дроби ===");

            Console.Write("Чисельник a: ");
            BigInteger nomA = BigInteger.Parse(Console.ReadLine());
            Console.Write("Знаменник a: ");
            BigInteger denA = BigInteger.Parse(Console.ReadLine());

            Console.Write("Чисельник b: ");
            BigInteger nomB = BigInteger.Parse(Console.ReadLine());
            Console.Write("Знаменник b: ");
            BigInteger denB = BigInteger.Parse(Console.ReadLine());

            MyFrac a = new MyFrac(nomA, denA);
            MyFrac b = new MyFrac(nomB, denB);

            FormulaTest(a, b);
        }

        static void ComplexTest()
        {
            Console.WriteLine("=== Введіть два комплексних числа ===");

            Console.Write("Дійсна частина a: ");
            double realA = double.Parse(Console.ReadLine());
            Console.Write("Уявна частина a: ");
            double imagiA = double.Parse(Console.ReadLine());

            Console.Write("Дійсна частина b: ");
            double reB = double.Parse(Console.ReadLine());
            Console.Write("Уявна частина b: ");
            double imB = double.Parse(Console.ReadLine());

            MyComplex a = new MyComplex(realA, imagiA);
            MyComplex b = new MyComplex(reB, imB);

            FormulaTest(a, b);
        }

        static void FormulaTest<T>(T a, T b) where T : IMyNumber<T>
        {
            Console.WriteLine($"=== Starting testing (a+b)^2=a^2+2ab+b^2 with a = {a}, b = {b} ===");

            T sum = a.Add(b);
            T left = sum.Multiply(sum);

            T a2 = a.Multiply(a);
            T ab2 = a.Multiply(b).Add(a.Multiply(b)); 
            T b2 = b.Multiply(b);

            T right = a2.Add(ab2).Add(b2);

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"(a + b) = {sum}");
            Console.WriteLine($"(a+b)^2 = {left}");
            Console.WriteLine("= = =");
            Console.WriteLine($"a^2 = {a2}");
            Console.WriteLine($"2*a*b = {ab2}");
            Console.WriteLine($"b^2 = {b2}");
            Console.WriteLine($"a^2+2ab+b^2 = {right}");

            Console.WriteLine($"=== Finishing testing (a+b)^2=a^2+2ab+b^2 with a = {a}, b = {b} ===");
        }
    }
}
