using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    internal class CustomerClub
    {
        #region Instance fields
        private double _clubDiscount = 0.95;

        #endregion

        #region Constructor
        public CustomerClub()
            {
            _clubDiscount = ClubDiscount;
            }
        #endregion

        #region Properties
        public double ClubDiscount

        { 
          get { return _clubDiscount; } 
          private set { _clubDiscount = value; }
        }



        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Kundeklub Rabat {ClubDiscount}";
        }

        #endregion
    }
}
