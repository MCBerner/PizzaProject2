﻿ using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject2
{
    public class Customer
    {
        int _customerID;
        string _name;
        string _address;
        string _phoneNumber;

        public Customer() 
        {
            _customerID = 0;
            _name = "";
            _address = "";
            _phoneNumber = "";
        }
        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }
        public string Name 
        {
            get { return _name; }
            set { _name = value; }

        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string PhoneNumber 
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }

        }
        public void CreateCustomer(int customerID, string name, string address, string phoneNumber) 
        {
            _customerID = customerID;
            _name = name;
            _address = address;
            _phoneNumber = phoneNumber;
        }
        public override string ToString() 
        {
            return $"Kunde.nr.{CustomerID} \nNavn: {Name} \nAdresse: {Address} \nTlf.nr: {PhoneNumber} ";
        }


    }
}
