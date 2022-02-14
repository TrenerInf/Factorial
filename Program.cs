using System;
using System.IO;
using System.Collections.Generic;

namespace factorial

{
    class Program
    {
        static void Main(string[] args)
        {
            string Message = "Введи целое число для которого хочешь посчитать факториал";
            uint x = InputUint(Message);
            Console.WriteLine("Факториал, посчитанный с помощью цикла со счетчиком");
            Console.WriteLine(Factorial(x));
            Console.WriteLine("Факториал, посчитанный с помощью рекурсии");
            Console.WriteLine(FactRecur(x));

        }

        static uint InputUint(string Message)
        {
            uint result;
            Console.WriteLine(Message);
            while (!uint.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Ошибка ввода");
                Console.WriteLine(Message);
            }
            return result;

        }

        static ulong Factorial(uint n)
        {
            ulong result = 1;
            for (uint i = 2; i <= n; i++)
                result *= i;
            return result;
        }
        static ulong FactRecur(uint n)
        {
            if (n == 0) return 1;
            if (n == 1) return 1;
            return n * FactRecur(n - 1);
        }
    }
}