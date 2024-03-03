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
        private string _name;
        private int _price;

        #endregion

        #region Constructor
          public Pizza(int menuNumber, string name, int price )
        {
            _menuNumber = menuNumber;
            _name = name;
            _price = price;
        }
        #endregion

        #region Properties

        public int MenuNumber
        {
            get { return _menuNumber; }
            private set { _menuNumber = value; }
        }   
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public int Price
        { 
            get { return _price; }
            private set { _price = value; } 
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Nr.{MenuNumber}: " +
                $"{Name} \n" +
                $"Price: {Price} \n";
        }

        #endregion

    }
}
