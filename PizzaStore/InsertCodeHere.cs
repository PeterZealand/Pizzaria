using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class InsertCodeHere
    {
        
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            {
                Pizza Pizza1 = new Pizza("Calzone", 50);

                Console.WriteLine($"what is the new pizzas name? {Pizza1.Name} and Price? {Pizza1.Price} kr.");

                Customer Customer1 = new Customer("Peter", 1, 1);
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}

