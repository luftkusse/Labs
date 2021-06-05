using System;
using System.Runtime.InteropServices;

namespace LAB_4_2
{
    static class Math
    {
        [DllImport("Math.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Sum(int a, int b);

        [DllImport("Math.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Minus(int a, int b);
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("a = " + a + "; b = " + b);
            Console.WriteLine("а + b = " + Math.Sum(a, b));
            Console.WriteLine("a - b = " + Math.Minus(a, b));


        }
    }
}