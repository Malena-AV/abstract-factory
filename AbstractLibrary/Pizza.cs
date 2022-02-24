using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLibrary
{
   abstract public class Pizza
    {
        public string description;
        public string Prepare()
        {
            return "пицца подготовлена";
        }
        public string Bake()
        {
            return "пицца испеклась";
        }
        public string Cut()
        {
            return "пицца разрезана";
        }
        public string Box()
        {
            return "пицца упакована";
        }
        public string Cheсk()
        {
            return description + ":\n" + Prepare() + "\n" + Bake()+ "\n" + Cut()+ "\n" + Box() + ("\n");
        }
    }
}
