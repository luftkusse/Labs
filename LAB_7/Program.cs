using System;

namespace LAB_7
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую пару чисел: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую пару чисел: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            RationalNumber example1 = new RationalNumber(a1, b1);
            RationalNumber example2 = new RationalNumber(a2, b2);
            Console.WriteLine("Перевод в string:");
            Console.WriteLine(example1.ToString());
            Console.WriteLine(example2.ToString());
            Console.WriteLine("Перевод в int:");
            Console.WriteLine(example1.ToString());
            Console.WriteLine(example2.ToString());
            Console.WriteLine("Математические операции");
            Console.WriteLine(a1 + "/" + b1 + " + " + a2 + "/" + b2 + " = " + (double)(example1 + example2));
            Console.WriteLine(a1 + "/" + b1 + " - " + a2 + "/" + b2 + " = " + (double)(example1 - example2));
            Console.WriteLine(a1 + "/" + b1 + " / " + a2 + "/" + b2 + " = " + (double)(example1 / example2));
            Console.WriteLine(a1 + "/" + b1 + " * " + a2 + "/" + b2 + " = " + (double)(example1 * example2));
            Console.WriteLine("Операции сравнения");
            Console.WriteLine(">");
            if (example1 > example2)
                Console.WriteLine($"{(double)example1}");
            else
                Console.WriteLine($"{(double)example2}");
            Console.WriteLine($"{(double)example2}");
            Console.WriteLine("<");
            if (example1 < example2)
                Console.WriteLine($"{(double)example1}");
            else
                Console.WriteLine($"{(double)example2}");

            Console.WriteLine(">= ");
            if (example1 >= example2)
                Console.WriteLine($"{(double)example1}");
            else
                Console.WriteLine($"{(double)example2}");
            Console.WriteLine("<=");
            if (example1 <= example2)
                Console.WriteLine($"{(double)example1}");
            else
                Console.WriteLine($"{(double)example2}");
            Console.WriteLine("==");

            if (example1 == example2)
                Console.WriteLine("Числа равны");
            else
                Console.WriteLine("Числа не равны");
        }
    }
}