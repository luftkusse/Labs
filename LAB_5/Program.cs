using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    class Program
    {
        static void Main(string[] args)
        {

            int l, w, h;

            Console.Write("Введите длину: ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину: ");
            w = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту: ");
            h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            var Classes = new List<Math>
            {
                new M1(l,w,h),
                new M2(l,w,h)
            };
            foreach (var i in Classes) i.Schet();

        }
    }
}