using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloppy_Joe_s_Budget_House_o__Discount_Sandwiches_
{
    internal class MenuItem
    {
        public static Random Randomizer = new Random();
        public string[] Proteins = { "Turkey", "Salami", "Roast Beef" };
        public string[] Condiments = {"Mustard", "Ketchup", "Mayonnaise"};
        public string[] Breads = {"Rye", "White", "Wheat"};
        public string Description = "";
        public string Price;

        public void Generate()
        {
            string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            Description = $"{randomProtein} with {randomCondiment} on {randomBread} Bread";

            decimal cash = Randomizer.Next(2, 5);
            decimal cents = Randomizer.Next(1, 98);
            decimal price = cash + (cents * 0.1M);
            Price = price.ToString("c");

        }
    }
}
