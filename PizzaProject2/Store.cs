using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject2
{
    public class Store
    {
        public Store()  //Constructor
        {

            Pizza pizzaKebab = new Pizza();
            pizzaKebab.PizzaID = 1;
            pizzaKebab.Name = "Kebab pizza";
            pizzaKebab.Description = "Pizza med kebab, tomat og ost...";
            pizzaKebab.Price = 95;

            //Pizza pizzaKebab = new Pizza();
            //pizzaKebab.CreatePizza(1, "Kebab pizza", "Pizza med kebab, tomat og ost...", 95);

            Pizza pizzaCalzone = new Pizza();
            pizzaCalzone.CreatePizza(2, "Calzone pizza", "Lukket pizza med kødsovs", 105);

            Pizza pizzaMexican = new Pizza();
            pizzaMexican.CreatePizza(3, "Mexican pizza", "Chilli con carne med revet ost", 100);

            string pizzakebabstring = pizzaKebab.ToString();
            string pizzacalzonestring = pizzaCalzone.ToString();
            string pizzamexicanstring = pizzaMexican.ToString();

            //Customer anders = new Customer();
            //anders.CustomerID = 1;
            //anders.Name = "Anders";
            //anders.Address = "Strandvejen 1";
            //anders.PhoneNumber = 33445566;

            Customer anders = new Customer();
            anders.CreateCustomer(1, "Anders", "Strandvejen 1", 33445566);

            Customer juliette = new Customer();
            juliette.CreateCustomer(2, "Juliette", "Sommerhuset", 33445678) ;

            Customer henrik = new Customer();
            henrik.CreateCustomer(3, "Henrik", "Svogerslev", 33448899);

            


            //Order order1 = new Order();
            /*order1.OrderID = 1;
            order1.Pizza = pizzaKebab;
            order1.Customer = anders;
            order1.Tax = 0.25;
            order1.DeliveryCosts = 40; 
            order1.TotalCosts = 0;*/

            Order order1 = new Order();
            order1.CreateOrder(1, pizzaKebab, anders);

            Order order2 = new Order();
            order2.OrderID = 2;
            order2.Pizza = pizzaCalzone;
            order2.Customer = juliette;
            order2.Tax = 0.25;
            order2.DeliveryCosts =
            order2.TotalCosts = 0;

            Order order3 = new Order();
            order3.OrderID = 3;
            order3.Pizza = pizzaMexican;
            order3.Customer = anders;
            order3.Tax = 0.25;
            order3.DeliveryCosts =
            order3.TotalCosts = 0;




            Console.WriteLine(anders.ToString());
            Console.WriteLine("");
            Console.WriteLine(pizzakebabstring.ToString());
            Console.WriteLine("");
            Console.WriteLine(order1.ToString());
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(juliette.ToString());
            Console.WriteLine("");
            Console.WriteLine(pizzacalzonestring.ToString());
            Console.WriteLine("");
            Console.WriteLine(order2.ToString());
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(henrik.ToString());
            Console.WriteLine("");
            Console.WriteLine(pizzamexicanstring.ToString());
            Console.WriteLine("");
            Console.WriteLine(order3.ToString());
            Console.WriteLine("");

            





        }


    }
}
