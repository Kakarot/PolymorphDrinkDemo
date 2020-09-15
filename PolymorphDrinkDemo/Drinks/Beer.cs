namespace PolymorphDrinkDemo.Drinks
{
    public class Beer : Drink
    {
        public Beer(string name, bool isCarbonated, double alcoholContent) : base(name, isCarbonated)
        {
            this.AlcoholContent = alcoholContent;
        }
        public double AlcoholContent { get; set; }
        public override string Description
        {
            get =>
                $@"{base.Name}, {(base.IsCarbonated ? "" : "not ")}carbonated, {this.AlcoholContent}%.";
        }
    }
}
