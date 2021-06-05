using System;

namespace LAB_6
{
    interface IComparable
    {
        void CompareTo();
    }
    public interface I_Fig
    {
        int GetP();
        int GetA();
        int GetV();
    }
    public class Class1 : I_Fig, IComparable
    {
        public int x, y, z;
        public Class1(int a, int b, int c)
        {
            x = a;
            y = b;
            z = c;
        }
        public void CompareTo()
        {
            if (x > z) Console.WriteLine("X > Z");
            if (z > x) Console.WriteLine("Z > X");
        }
        public int GetA()
        {
            return x * z;
        }
        public int GetP()
        {
            return (x + z) * 2;
        }
        public int GetV()
        {
            return x * y * z;
        }
    }
}