using System;
using System.Collections.Generic;
using PolymorphDrinkDemo.Drinks;

namespace PolymorphDrinkDemo
{
    /*
     * Author: James Ruiz
     * Date: September 15, 2020
     */

    /// <summary>
    /// Driver class to demonstrate polymorphic behavior
    /// </summary>
    /// <remarks>
    /// I prefer to use the "this" keyword in object oriented languages
    /// I could have used a drink interface instead of inheritance to demo polymorphism
    /// I relied on the base class when appropriate, this means not all subclasses will overwrite the Description property
    /// I removed unused namespaces, including "System" in classes where this was not needed
    /// This was fun.
    /// </remarks>
    public class MainClass
    {
        public static void Main(string[] args)
        {
            var listOfDrinks = new List<Drink>();
            listOfDrinks.Add(new Juice("Orange Juice", false, "orange"));
            listOfDrinks.Add(new Beer("Budweiser", true, 5d));
            listOfDrinks.Add(new Soda("Pepsi", true));

            foreach(var drink in listOfDrinks)
            {
                Console.WriteLine(drink.Description);
            }
        }
    }
}
