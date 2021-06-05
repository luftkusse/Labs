using System;

namespace LAB_3
{
    class Characteristic
    {
        private static void ID()
        {
            Random r = new Random();
            int id = r.Next(1000000, 9999999);
            Console.WriteLine("ID представителя: " + id);
        }

        public void Difference()
        {
            Console.WriteLine("Введите возраст расы: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 2600000)
            {
                Console.WriteLine("Эта раса старше человечества примерно на " + (age - 2600000) + " лет");
            }
            else
            {
                Console.WriteLine("Эта раса младше человечества примерно на " + (2600000 - age) + " лет");
            }
            ID();
        }
    }
}

