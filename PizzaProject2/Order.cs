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
        Pizza _pizza;
        Customer _customer;
        double _tax;
        int _deliveryCosts;
        int _totalCosts;

        public Order()
        {
            _orderID = 0;
            _pizza = null;
            _customer = null;
            _tax = 0.25;
            _deliveryCosts = 40;
            _totalCosts = 0;
            

        }
        public int OrderID 
        {
            get { return _orderID; }
            set { _orderID = value; }
        }
        public  Pizza Pizza  
        {
            get { return _pizza; }
            set { _pizza = value;}
        }
        public Customer Customer 
        {
            get { return _customer; }
            set { _customer = value;}
        }
        public double Tax 
        {
            get { return _tax; }
            set { _tax = value;}
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
        public void CreateOrder(int orderID, Pizza pizza, Customer customer, double tax, int deliveryCosts,int totalCosts)
        {
            //_pizzaID++;
            _orderID = orderID;
            _pizza = pizza;
            _customer = customer;
            _tax = tax;
            _deliveryCosts = deliveryCosts;
            _totalCosts = totalCosts;

        }


        public override string ToString()
        {
            return $"OrderID: {OrderID} - PizzaID: {Pizza} - CustomerID: {Customer} - TotalCosts: {TotalCosts} ";
        }
    }
}
