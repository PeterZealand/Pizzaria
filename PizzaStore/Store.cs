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

        

        //testing fields for console writes and different ways of using the ToString method.
            /* Console.WriteLine($"{customer1.Name} bestiller en {pizza1.Name} pizza som koster {pizza1.Price}");
            Console.WriteLine();
            Console.WriteLine($"{customer2.Name} bestiller en {pizza2.Name} pizza som koster {pizza2.Price}");
            Console.WriteLine();
            Console.WriteLine($"{customer3.Name} \n bestiller en {pizza3.Name} pizza som koster {pizza3.Price}");
            Console.WriteLine();

            Console.WriteLine((customer1, pizza1, order1));
            
            Console.WriteLine(customer1.ToString()+""+pizza1.ToString()+""+order1.ToString());
            */


        #region Methods

        public void Start()
        {
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("Welcome to Big Mammas Pizza Take Away");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * *");

            //creation of Pizzas
            Pizza pizza1 = new Pizza(1, "Calzone", 80);
            Pizza pizza2 = new Pizza(2, "Hawaii", 70);
            Pizza pizza3 = new Pizza(3, "Ham", 60);

            //creation of Customers
            Customer customer1 = new Customer("Peter", "Holbæk", 12345678);
            Customer customer2 = new Customer("Morten", "Roskilde", 87654321);
            Customer customer3 = new Customer("Paprika", "Hårlev", 13245768);

            //creation of Orders
            Order order1 = new Order(customer1, pizza1);
            Order order2 = new Order(customer2, pizza2);
            Order order3 = new Order(customer3, pizza3);


            //layout for console and the use of the ToString() method gathered in the Order Class
            Console.WriteLine();
            Console.WriteLine("Todays Menu?");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine();
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine(order1);
            Console.WriteLine();
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine();
            Console.WriteLine(order2);
            Console.WriteLine();
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine();
            Console.WriteLine(order3);
            Console.WriteLine();
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine();


        }




        #endregion

    }
}

