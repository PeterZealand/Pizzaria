using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class Pizza
    {
        #region Instance fields
        private static int _menuNumber = 1;
        public static void Reset()
        {
            _menuNumber = 0;
        }
        #endregion

        #region Constructor
        public Pizza(string pizzaName, int price)
        {
            
            PizzaName = pizzaName;
            Price = price;
            MenuNumber = _menuNumber;
            MenuNumbers();
            
        }
        public Pizza()
        {
            MenuNumber = _menuNumber;
            MenuNumbers();

        }
        #endregion

        #region Properties

        public int MenuNumber
        {
            get; set;
        }
        public string PizzaName
        {
            get; set;
        }
        public int Price
        {
            get; set;
        }
        #endregion

        #region Methods
        public static int MenuNumbers()
        {
            _menuNumber++;
            return _menuNumber;
        }

        public static Pizza Parse(string input)
        {
            return new Pizza();
        }
        
        public override string ToString()
        {
            return $"Nr.{MenuNumber}: " +
                $" {PizzaName}, " +
                $"Price: {Price} \n";
        }
        #endregion
    }
}
