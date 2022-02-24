using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLibrary
{
    public class PizzaStore
    {
        SimplePizzaFactory factore;
        public PizzaStore(SimplePizzaFactory factore)
        {
            this.factore = factore;
        }
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = factore.CreatePizza(type);
            return pizza;
        }
    }
}
