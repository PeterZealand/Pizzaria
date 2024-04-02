using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    internal class Toppings
    {
        #region Instance fields

        #endregion

        #region Constructor
        public Toppings(string toppingName, int price) 
        {
            ToppingName = toppingName;
            Price = price;
        }

        #endregion

        #region Properties
        public string ToppingName 
        { get; set; }

        public int Price 
        { get; set; }  
        #endregion

        #region collections


        #endregion

        #region Methods

        
        #endregion
    }
}
