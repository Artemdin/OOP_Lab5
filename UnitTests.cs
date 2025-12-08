using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    internal class UnitTests
    {
        //  додавання дробів
        public static void TestAddMyFrac(MyFrac a, MyFrac b)
        {
            Console.WriteLine("=== Test Add MyFrac ===");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            MyFrac result = a.Add(b);
            Console.WriteLine("a + b = " + result);
            Console.WriteLine("====================\n");
        }

        // віднімання дробів
        public static void TestSubtractMyFrac(MyFrac a, MyFrac b)
        {
            Console.WriteLine("=== Test Subtract MyFrac ===");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            MyFrac result = a.Subtract(b);
            Console.WriteLine("a - b = " + result);
            Console.WriteLine("====================\n");
        }

        // множення дробів
        public static void TestMultiplyMyFrac(MyFrac a, MyFrac b)
        {
            Console.WriteLine("=== Test Multiply MyFrac ===");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            MyFrac result = a.Multiply(b);
            Console.WriteLine("a * b = " + result);
            Console.WriteLine("====================\n");
        }

        // ділення дробів
        public static void TestDivideMyFrac(MyFrac a, MyFrac b)
        {
            Console.WriteLine("=== Test Divide MyFrac ===");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            try
            {
                MyFrac result = a.Divide(b);
                Console.WriteLine("a / b = " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException caught!");
            }

            Console.WriteLine("====================\n");
        }

        // для комплексних чисел операції
        public static void TestAddMyComplex(MyComplex a, MyComplex b)
        {
            Console.WriteLine("=== Test Add MyComplex ===");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            MyComplex result = a.Add(b);
            Console.WriteLine("a + b = " + result);
            Console.WriteLine("====================\n");
        }

        public static void TestSubtractMyComplex(MyComplex a, MyComplex b)
        {
            Console.WriteLine("=== Test Subtract MyComplex ===");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            MyComplex result = a.Subtract(b);
            Console.WriteLine("a - b = " + result);
            Console.WriteLine("====================\n");
        }

        public static void TestMultiplyMyComplex(MyComplex a, MyComplex b)
        {
            Console.WriteLine("=== Test Multiply MyComplex ===");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            MyComplex result = a.Multiply(b);
            Console.WriteLine("a * b = " + result);
            Console.WriteLine("====================\n");
        }

        public static void TestDivideMyComplex(MyComplex a, MyComplex b)
        {
            Console.WriteLine("=== Test Divide MyComplex ===");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            try
            {
                MyComplex result = a.Divide(b);
                Console.WriteLine("a / b = " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException caught!");
            }

            Console.WriteLine("====================\n");
        }

        // Загальний тест (всі операції)
        public static void RunAllTests()
        {
            // Дроби
            MyFrac f1 = new MyFrac(1, 3);
            MyFrac f2 = new MyFrac(1, 6);

            TestAddMyFrac(f1, f2);
            TestSubtractMyFrac(f1, f2);
            TestMultiplyMyFrac(f1, f2);
            TestDivideMyFrac(f1, f2);

            // Комплексні
            MyComplex c1 = new MyComplex(1, 3);
            MyComplex c2 = new MyComplex(1, 6);

            TestAddMyComplex(c1, c2);
            TestSubtractMyComplex(c1, c2);
            TestMultiplyMyComplex(c1, c2);
            TestDivideMyComplex(c1, c2);

            Console.WriteLine("=== All tests completed ===");
        }
    }
}
    
