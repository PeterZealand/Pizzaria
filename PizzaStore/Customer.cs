using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Customer
    {
        #region Instance fields
        private string _name;
        private int _order;
        private int _orderNumber;

        #endregion

        #region Constructor
        public Customer(string Name, int Order, int OrderNumber)
        {
            _name = Name;
            _order = Order;
            _orderNumber = OrderNumber;
        }

        #endregion

        #region Properties

        public string Name 
        { 
            get { return _name; } 
        }

        public int Order
        {
            get { return _order; }
        }

        public int OrderNumber
        {
            get { return _orderNumber; }
        }
        #endregion

        #region Methods

        #endregion
    }
}
