using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Store
    {
        #region Instance fields
       

        #endregion

        #region Constructor

        #endregion

        #region Properties

        #endregion

        #region Methods

        public void Start()
        {
            Pizza pizza1 = new Pizza("Calzone", 80);
            Pizza pizza2 = new Pizza("Hawaii", 70);
            Pizza pizza3 = new Pizza("Ham", 60);

            Customer customer1 = new Customer("Peter");
            Customer customer2 = new Customer("Morten");
            Customer customer3 = new Customer("Paprika");

            Order order1 = new Order(1, customer1, pizza1);

            Order order2 = new Order(2, customer2, pizza2);

            Order order3 = new Order(3, customer3, pizza3);

            Console.WriteLine($"{customer1.Name} bestiller en {pizza1.Name} pizza som koster {pizza1.Price}");
            Console.WriteLine();
            Console.WriteLine($"{customer2.Name} bestiller en {pizza2.Name} pizza som koster {pizza2.Price}");
            Console.WriteLine();
            Console.WriteLine($"{customer3.Name} bestiller en {pizza3.Name} pizza som koster {pizza3.Price}");
            Console.WriteLine();

            Console.WriteLine((customer1, pizza1, order1));
            Console.WriteLine((customer2, pizza2, order2)); 
            Console.WriteLine((customer3, pizza3, order3));  
        }




        #endregion

    }
}

