using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject2
{
    public class Pizza
    {
        string _name;
        int _price;

        public Pizza()
        {
            _name = "";
            _price = 0;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }


    }
}
