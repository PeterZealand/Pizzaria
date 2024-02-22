using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Order
    {
        #region Instance fields

        private double _taxProcent;
        private double _deliveryCosts;
        Pizza p;

        #endregion

        #region Constructor

        public Order()
        {
            /*
            p = new Pizza();
            TaxProcent = 1.39;
            DeliveryCosts = 49.0;
            */
        }
        #endregion

        #region Properties
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

        #endregion

        #region Methods
        /*
        public double CalcTotalPrice()

        {
            totalPrice = ((p * _taxProcent) + _deliveryCosts);
        }
        */
        #endregion
    }
}
