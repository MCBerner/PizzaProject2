using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject2
{
    public class Store
    {
        public Store()  
        {

            Pizza pizzaKebab = new Pizza();
            pizzaKebab.PizzaID = 1;
            pizzaKebab.Name = "Kebab pizza";
            pizzaKebab.Description = "Pizza med kebab, tomat og ost...";
            pizzaKebab.Price = 95;


            Pizza pizzaCalzone = new Pizza();
            pizzaCalzone.CreatePizza(2, "Calzone pizza", "Lukket pizza med kødsovs", 105);

            Pizza pizzaMexican = new Pizza();
            pizzaMexican.CreatePizza(3, "Mexican pizza", "Chilli con carne med revet ost", 100);

            string pizzakebabstring = pizzaKebab.ToString();
            
            Customer anders = new Customer();
            anders.CustomerID = 1;
            anders.Name = "Anders";
            anders.Address = "Strandvejen 1";
            anders.PhoneNumber = 33445566;

            Order order1 = new Order();
            order1.OrderID = 1;
            order1.Pizza = pizzaKebab;
            order1.Customer = anders;
            order1.Tax = 0.25;
            order1.DeliveryCosts =
            order1.TotalCosts = 0;


            Console.WriteLine(anders.ToString());
            Console.WriteLine(pizzakebabstring);
            Console.WriteLine(order1.ToString());
            Console.WriteLine("");

            Console.WriteLine(pizzaCalzone.ToString());
            Console.WriteLine(pizzaMexican.ToString());

            



        }


    }
}
