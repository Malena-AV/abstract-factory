using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractLibrary;



namespace abstract_factory1
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory factore = new SimplePizzaFactory();
            PizzaStore pizza = new PizzaStore(factore);

            Console.WriteLine(pizza.OrderPizza("CheesePizza").Cheсk());
            Console.WriteLine(pizza.OrderPizza("PepperoniPizza").Cheсk());
            Console.WriteLine(pizza.OrderPizza("ClamPizza").Cheсk());
            Console.WriteLine(pizza.OrderPizza("VeggiePizza").Cheсk());

            Console.ReadLine();
        }
    }
}
