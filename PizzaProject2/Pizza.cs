using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject2
{
    public class Pizza
    {
        int _pizzaID;
        string _name;
        string _description;
        int _price;

        public Pizza()
        {
            _pizzaID = 0;
            _name = "";
            _description = "";
            _price = 0;
        }
        public int PizzaID
        {
            get { return _pizzaID; }
            set { _pizzaID = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public void CreatePizza(int pizzaID, string name, string description, int price)
        {
            
            _pizzaID = pizzaID;
            _name = name;
            _description = description;
            _price = price;
           
        }

        //overskriver default ToString metoden, så jeg bestemmer min egen med hvad den skal udskrive
        public override string ToString()
        {
            return $"Pizza nummer: {PizzaID} -  {Name} - Toppings: {Description} - Pris: {Price} ";
        }



    }
}
