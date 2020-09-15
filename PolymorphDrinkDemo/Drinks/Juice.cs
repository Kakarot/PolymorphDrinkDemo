using System;
namespace PolymorphDrinkDemo.Drinks
{
    public class Juice : Drink
    {
        public Juice(string name, bool isCarbonated, string fruit):base(name,isCarbonated)
        {
            this.Fruit = fruit;
        }
        public string Fruit { get; set; }
        public override string Description {
            get =>
                @$"{base.Name}, {(base.IsCarbonated ? "is":"not")}, made from {this.Fruit}";
        }
    }
}
