using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Customer
    {
        #region Instance fields
        private string _name;
        private string _adress;
        private int _phoneNumber;

        #endregion

        #region Constructor
        public Customer(string Name, string Adress, int PhoneNumber)
        {
            _name = Name;
            _adress = Adress;
            _phoneNumber = PhoneNumber;
        }

        #endregion

        #region Properties

        public string Name 
        { 
            get { return _name; } 
        }

        public string Adress
        {
            get { return _adress; }
        }

        public int PhoneNumber
        {
            get { return _phoneNumber; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"name: {Name} \n " +
                $"adress {Adress} \n" +
                $"Phone Number {PhoneNumber} \n";
        }
        #endregion
    }
}
