namespace PolymorphDrinkDemo.Drinks
{
    public class Soda : Drink
    {
        public Soda(string name, bool isCarbonated) : base(name, isCarbonated)
        { }

        //No need to override the description property since the base class is good enough

    }
}
