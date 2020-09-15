namespace PolymorphDrinkDemo.Drinks
{
    public class Drink
    {
        public Drink(string name, bool isCarbonated)
        {
            //I like the 'this' keyword
            this.Name = name;
            this.IsCarbonated = isCarbonated;
        }
        public string Name { get; set; }
        public bool IsCarbonated { get; set; }
        public virtual string Description
        {
            get =>
                $@"{Name}, {(IsCarbonated ? "" : "not ")}carbonated.";
        }
    }
}
