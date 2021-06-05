using System;

namespace LAB_8
{
    class Program
    {
        delegate int Operation(int a, int b, int c, int d);
        delegate void MessageHandler(string message);
        static void SMessage(string message, MessageHandler handler)
        {
            handler(message);
        }
        delegate void Message();
        static void Main(string[] args)
        {
            Operation operation = (a, b, c, d) => a + b + c + d;
            int s = 0;
            while (s != 5)
            {
                
                Console.WriteLine("Введите цифру, чтобы вывести информацию:\n1 - Эльф\n2 - Оборотень\n3 - Вампир\n4 - очистить коноль");
                try
                {
                    s = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                }
                switch (s)
                {
                    case 1:
                        Elf elf = new Elf("Лук", "Самый известный эльф", "Леголас", 3000, "Северное Лихолесье");
                        Console.WriteLine(elf);
                        elf.ByTheWay();
                        break;
                    case 2:
                        Werewolf werewolf = new Werewolf("Собственное тело", "Один из самых известных оборотней", "Питер Штампф", 496, "Бедбург");
                        Console.WriteLine(werewolf);
                        werewolf.ByTheWay();
                        break;
                    case 3:
                        Vampir vampir = new Vampir("Клыки", "Самый известный вампир", "Влад III Цепеш (Дракула)", 590, "Венгрия");
                        Console.WriteLine(vampir);
                        Vampir vampir1 = new Vampir("Клыки", "Второй по известности вампир", "Элизабет (Эржебет) Батори", 461, "Венгрия");
                        vampir1.CloneC += (x) => Console.WriteLine("Граф Дракула склонирован и слегка подредактирован...  {0}", (x as Human).Name);
                        vampir1.CloneC += delegate (object clone)
                        {
                            Console.Write("Клон как человек : ");
                            (clone as Human).Info();
                        };
                        vampir.ByTheWay();
                        break;
                    case 4:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}