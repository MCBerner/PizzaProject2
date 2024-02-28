using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaProject2
{
   

    public class Order
    { 
        int _orderID;
        int _pizzaID;
        int _customerID;
        int _tax;
        int _deliveryCosts;
        int _totalCosts;

        public Order()
        {
            _orderID = 0;
            _pizzaID = 0;
            _customerID = 0;
            _tax = 25;
            _deliveryCosts = 40;
            _totalCosts = 0;
            

        }
        public int OrderID 
        {
            get { return _orderID; }
            set { _orderID = value; }
        }
        public int PizzaID 
        {
            get { return _pizzaID; }
            set { _pizzaID = value;}
        }
        public int CustomerID 
        {
            get { return _customerID; }
            set { _customerID = value;}
        }
        public int Tax 
        {
            get { return _tax; }

        }
        public int DeliveryCosts 
        {
            get { return _deliveryCosts; }
            set { _deliveryCosts = value;}
        }
        public int TotalCosts 
        {
            get { return _totalCosts; }
            set { _totalCosts = value;}
        }
        public void CreatePizza(int orderID, int pizzaID, int customerID, int tax, int deliveryCosts,int totalCosts)
        {
            //_pizzaID++;
            _orderID = orderID;
            _pizzaID = pizzaID;
            _customerID = customerID;
            _tax = tax;
            _deliveryCosts = deliveryCosts;
            _totalCosts = totalCosts;

        }
        public override string ToString()
        {
            return $"OrderID: {OrderID} - PizzaID: {PizzaID} - CustomerID: {CustomerID} - TotalCosts: {TotalCosts} ";
        }
    }
}
