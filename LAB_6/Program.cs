using System;

namespace LAB_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, w, h;
            Console.Write("Длина основания: ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ширина основания: ");
            w = Convert.ToInt32(Console.ReadLine());
            Console.Write("Высота: ");
            h = Convert.ToInt32(Console.ReadLine());

            Class1 a = new Class1(l, w, h);
            Console.WriteLine("Площадь основания: {0}", a.GetA());
            Console.WriteLine("Периметр основания: {0}", a.GetP());
            Console.WriteLine("Объём: {0}\n", a.GetV());

        }
    }
}