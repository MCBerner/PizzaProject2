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

            Pizza pizzaContadina = new Pizza();
            pizzaContadina.PizzaID = 1;
            pizzaContadina.Name = "Contadina";
            pizzaContadina.Description = "Tomat, ost, champignon og oliven";
            pizzaContadina.Price = 75;

            Pizza pizzaNaples = new Pizza();
            pizzaNaples.CreatePizza(2, "Naples ", "Tomat , ost, ansjoser,og oliven", 79);

            Pizza pizzaBigMamma = new Pizza();
            pizzaBigMamma.CreatePizza(3, "Big mamma", "Tomat, gorgonzola, reje, apsparges og parma skinke", 90);

            string pizzacontadinastring = pizzaContadina.ToString();
            string pizzanaplesstring = pizzaNaples.ToString();
            string pizzabigmammastring = pizzaBigMamma.ToString();


            Customer anders = new Customer();
            anders.CreateCustomer(1, "Anders", "Strandvejen 1", 33445566);

            Customer juliette = new Customer();
            juliette.CreateCustomer(2, "Juliette", "Sommerhuset", 33445678) ;

            Customer henrik = new Customer();
            henrik.CreateCustomer(3, "Henrik", "Svogerslev", 33448899);


            Order order1 = new Order();
            order1.CreateOrder(1, pizzaContadina, anders);

            Order order2 = new Order();
            order2.CreateOrder(2, pizzaNaples, juliette);

            Order order3 = new Order();
            order3.CreateOrder(3, pizzaBigMamma, henrik);



            Console.WriteLine(anders);
            Console.WriteLine("");
            Console.WriteLine(pizzacontadinastring);
            Console.WriteLine("");
            Console.WriteLine(order1);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(juliette);
            Console.WriteLine("");
            Console.WriteLine(pizzanaplesstring);
            Console.WriteLine("");
            Console.WriteLine(order2);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(henrik);
            Console.WriteLine("");
            Console.WriteLine(pizzabigmammastring);
            Console.WriteLine("");
            Console.WriteLine(order3);
            Console.WriteLine("");

            





        }


    }
}
