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

        private int _menuNumber;
        private string _pizzaName;
        private int _price;

        #endregion

        #region Constructor
          public Pizza(int menuNumber, string pizzaName, int price )
        {
            _menuNumber = menuNumber;
            _pizzaName = pizzaName;
            _price = price;
        }
        #endregion

        #region Properties

        public int MenuNumber
        {
            get { return _menuNumber; }
            private set { _menuNumber = value; }
        }   
        public string PizzaName
        {
            get { return _pizzaName; }
            private set { _pizzaName = value; }
        }
        public int Price
        { 
            get { return _price; }
            private set { _price = value; } 
        }
        #endregion

        #region Methods
        //Method for console writing info from pizza class
        public override string ToString()
        {
            return $"Nr.{MenuNumber}: " +
                $"{PizzaName} \n" +
                $"Price: {Price} \n";
        }

        #endregion

    }
}
