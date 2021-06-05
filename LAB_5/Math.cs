using System;

namespace LAB_5
{
    public abstract class Math
    {
        public abstract int Schet();
    }
    public class M1 : Math
    {
        public int length, width, height;
        public M1(int a, int b, int c)
        {
            length = a;
            width = b;
            height = c;
        }
        public override int Schet()
        {
            Console.WriteLine("Вы не переопределили метод " + "\"" + (length * width * height) + "\"\n");
            return (length * width * height);
        }
    }
    public class M2 : Math
    {
        public int length, width, height;
        public M2(int a, int b, int c)
        {
            length = a * 2;
            width = b * 2;
            height = c * 2;
        }
        public override int Schet()
        {
            Console.WriteLine("Вы переопределили метод " + "\"" + (length * width * height) + "\"\n");
            return (length * width * height);
        }

    }
}