namespace LAB_8
{
    public class Humanoid : Human
    {
        public string Weapon { get; private set; }
        public string Features { get; private set; }
        public Humanoid(string weapon, string features,
                       string name, int age, string homeland)
            : base(name, age, homeland)
        {
            Weapon = weapon;
            Features = features;
        }
    }
}