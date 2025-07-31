using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    internal class MyMethods
    {
        public static int Add(int a, int b)  
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            if (b == 0) return 0;
            return a / b;    // avoid divide by zero
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("\n Math Operations Menu:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit\n");
        }
    }
}
