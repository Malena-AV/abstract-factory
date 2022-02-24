using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLibrary
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type == "CheesePizza")
            {
                pizza = new CheesePizza();
            }
            else if (type == "ClamPizza")
            {
                pizza = new ClamPizza();
            }
            else if (type == "PepperoniPizza")
            {
                pizza = new PepperoniPizza();
            }
            else if (type == "VeggiePizza")
            {
                pizza = new VeggiePizza();
            }
            return pizza;
        }

    }
}
