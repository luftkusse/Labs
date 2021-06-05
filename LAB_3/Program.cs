using System;

namespace LAB_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Characteristic characteristic = new Characteristic();
            Race race = new Race();
            int i = 0;
            char c = ' ';
            while (c != 'R' || c != 'W' || c != 'C' || c != 'r' || c != 'w' || c != 'c')
            {
                Console.WriteLine("R - просмотреть\nW - записать\nC - очистить консоль");
                c = Convert.ToChar(Console.ReadLine());
                switch (c)
                {
                    case 'W':
                    case 'w':
                        Console.WriteLine("Введите название");
                        race.Name = Console.ReadLine();
                        Console.WriteLine("Введите количество представителей");
                        race.NumberOfRepresentatives = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите особенность");
                        race.Feature = Console.ReadLine();
                        characteristic.Difference();
                        i++;
                        break;
                    case 'R':
                    case 'r':
                        Console.WriteLine(race.Name + ", количество представителей: " + race.NumberOfRepresentatives + ", особенность: " + race.Feature);
                        break;
                    case 'C':
                    case 'c':
                        Console.Clear();
                        break;
                }
            }
        }
    }
}