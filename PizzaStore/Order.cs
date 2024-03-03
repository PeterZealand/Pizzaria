﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    internal class Order
    {
        #region Instance fields

        private double _taxPercent = 1.25;
        private double _deliveryCosts = 40;
        private int _orderId = 0;
        private Pizza _pizza;
        private Customer _customer;
        #endregion

        #region Constructor

        public Order(int orderId, Customer customer, Pizza pizza )
        {
            _orderId = orderId;
            _pizza = pizza;
            _customer = customer;
            
        }
        #endregion

        #region Properties
        public Pizza Pizza
        
        {
            get { return _pizza; }
            private set { _pizza = value; }
        }
        public Customer Customer
        {
            get { return _customer; }
            private set { _customer = value; }
        }
        
        public double TaxPercent
        { 
            get { return _taxPercent; }
            private set { _taxPercent = value; } 
        }

        public double DeliveryCosts 
        
        { 
            get { return _deliveryCosts; }
            private set { _deliveryCosts = value; }
        }
        public int OrderId
        {
            get { return _orderId; }
            private set { _orderId = value; }
        }
       


        #endregion

        #region Methods


        public double CalcTotalPrice()

        {
           
           double TotalPrice = (Pizza.Price * TaxPercent) + DeliveryCosts;

           return TotalPrice;  
        }

        public override string ToString()
        {
            return $"Order ID {OrderId} \n" +
                $"Customer {_customer.ToString()}" +
                $"Pizza {_pizza.ToString()}" +
                $"Tax 25%" +
                $" + Delivery Costs {DeliveryCosts} \n" +
                $"Total price {CalcTotalPrice()} ";
        }

        #endregion
    }
}
