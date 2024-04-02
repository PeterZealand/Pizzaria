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
        private bool _customerClubMember;

        #endregion

        #region Constructor
        public Customer(string name, string adress, int phoneNumber, bool customerClubMember)
        {
            _name = name;
            _adress = adress;
            _phoneNumber = phoneNumber;
            _customerClubMember = customerClubMember;
        }

        #endregion

        #region Properties

        public string Name 
        { 
            get { return _name; }
            private set { _name = value; }
        }

        public string Adress
        {
            get { return _adress; }
            private set { _adress = value; }
        }

        public int PhoneNumber
        {
            get { return _phoneNumber; }
            private set { _phoneNumber = value; }
        }
        public bool CustomerClubMember

        {
            get { return _customerClubMember; }
            private set { _customerClubMember = value; }
        }
        #endregion

        #region Methods
        //Method for console writing info from Customer class
        public override string ToString()
        {
            return $"Name: {Name} \n" +
                $"Adress: {Adress} \n" +
                $"Phone Number: {PhoneNumber} \n";
        }
        #endregion
    }
}
