namespace LAB_8
{
    public class Elf : Humanoid
    {
        public Elf(string weapon, string features, 
            string name, int age, string homeland)
                 : base(weapon, features, name, age, homeland)
        {
        }
        public override string ToString()
        {
            return "Человекоподобный: \nИмя - " + Name + "  \nВозраст - " + Age + "  \nРодина - " + Homeland +
                 "  \nРост -" + Height + "\t" +
            "\nОружие - " + Weapon + "  \nОсобенности - " + Features;
        }
    }
}