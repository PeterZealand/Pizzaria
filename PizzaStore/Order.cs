using System;
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

        private double _taxProcent = 1.25;
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
            set { _pizza = value; }
        }
        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }
        
        public double TaxProcent
        { 
            get { return _taxProcent; } 
            set { _taxProcent = value; } 
        }

        public double DeliveryCosts 
        
        { 
            get { return _deliveryCosts; }
            set { _deliveryCosts = value; }
        }
        public int OrderId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }
       


        #endregion

        #region Methods


        public double CalcTotalPrice()

        {
           
           double TotalPrice = (Pizza.Price * TaxProcent) + DeliveryCosts;

           return TotalPrice;  
        }

        public override string ToString()
        {
            return $"customer{_customer.ToString()} pizza{_pizza.ToString()} Moms {TaxProcent} - Leverings omkostninger {DeliveryCosts} \n Total price {CalcTotalPrice()} ";
        }

        #endregion
    }
}
