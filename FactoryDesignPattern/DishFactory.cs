using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class DishFactory
    {
    public static IAppitezer CreateAppitezerDish(string DishType)
        {
            return DishType switch
            {
                "ChieckenSalat" => new ChieckenSalat("", "", 1,new List<string> { }) ,
                "Buttercracker" => new Buttercracker("", "", 1, new List<string> { }),
                "CheesseTwist" => new CheesseTwist("", "", 1, new List<string> { })

            };

        }
    
    }

}
