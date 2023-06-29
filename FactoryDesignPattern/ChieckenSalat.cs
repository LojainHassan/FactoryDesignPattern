using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class ChieckenSalat : Dish, IAppitezer
    {
        public ChieckenSalat(string Size, string Calories, decimal price, List<string> Ingredients)
            :base(Size, Calories, price, Ingredients)
        {
            
        }

        public void Serve()
        {
            Console.WriteLine($"Chiecken salat \n --------------------- \n {ShowDetailes()}");        }
    }




    public class Buttercracker : Dish, IAppitezer
    {
        public Buttercracker(string Size, string Calories, decimal price, List<string> Ingredients)
            : base(Size, Calories, price, Ingredients)
        {

        }

        public void Serve()
        {
            Console.WriteLine($"Buttercracker \n --------------------- \n {ShowDetailes()}");
        }
    }


    public class CheesseTwist : Dish, IAppitezer
    {
        public CheesseTwist(string Size, string Calories, decimal price, List<string> Ingredients)
            : base(Size, Calories, price, Ingredients)
        {

        }

        public void Serve()
        {
            Console.WriteLine($"CheesseTwist \n --------------------- \n {ShowDetailes()}");
        }
    }


    public class PotatoBite : Dish, IAppitezer
    {
        public PotatoBite(string Size, string Calories, decimal price, List<string> Ingredients)
            : base(Size, Calories, price, Ingredients)
        {

        }

        public void Serve()
        {
            Console.WriteLine($"PotatoBite \n --------------------- \n {ShowDetailes()}");
        }
    }

}
