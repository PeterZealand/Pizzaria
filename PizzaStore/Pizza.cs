using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Pizza
    {
        #region Instance fields

        string _name;
        int _price;

        #endregion

        #region Constructor
          public Pizza()
        {
            _name = "";
            _price = 0;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Price
        { 
            get { return _price; } 
            set { _name = value; } 
        }
        #endregion

        #region Methods

        #endregion

    }
}
