using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public abstract class Dish
    {
        public string Size { get; set; }
        public string Calories { get; set; }
        public decimal Price { get; set; } 
        public List<string> Ingredients { get; set; }

        public Dish(string Size , string Calories , decimal price , List<string> Ingredients)
        {
            this.Size = Size;
            this.Calories = Calories;
            this.Price = price;
            this.Ingredients = Ingredients;
        }

        protected string ShowDetailes()
        {
            return $"Size is {Size} , {Calories} .cal , price is : {Price} ";
        }

    }
}
