using System;
namespace LAB_8
{
    public class Human : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Homeland { get; set; }
        public int Height { get; set; }
        public Type Type { get; set; }
        public Human(string name, int age, string homeland)
        {
            Name = name;
            Homeland = homeland;
            Age = age;
            Type = Type.Humanoid;
            Height = 155;
        }
        public Human(string name, int age, string homeland, Type type)
        {
            Name = name;
            Homeland = homeland;
            Age = age;
            Type = type;
        }
        public virtual void Info()
        {
            Console.WriteLine($"\nИмя = {Name}\nВозраст = {Age}\nРодина = {Homeland}\n");
        }
        public delegate void Action(object x);
        public event Action CloneC;
        public object Clone()
        {
            CloneC?.Invoke(this.MemberwiseClone());
            return this.MemberwiseClone();
        }
        public void ByTheWay()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            Console.WriteLine("Кстати, уже " + date.ToShortTimeString() + "\n");
        }
    }
}