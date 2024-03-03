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

        


            /* Console.WriteLine($"{customer1.Name} bestiller en {pizza1.Name} pizza som koster {pizza1.Price}");
            Console.WriteLine();
            Console.WriteLine($"{customer2.Name} bestiller en {pizza2.Name} pizza som koster {pizza2.Price}");
            Console.WriteLine();
            Console.WriteLine($"{customer3.Name} \n bestiller en {pizza3.Name} pizza som koster {pizza3.Price}");
            Console.WriteLine();

            Console.WriteLine((customer1, pizza1, order1));
            Console.WriteLine((customer2, pizza2, order2));
            Console.WriteLine((customer3, pizza3, order3));

            Console.WriteLine(customer1.ToString()+""+pizza1.ToString()+""+order3.ToString());
            */


        #region Methods

        public void Start()
        {
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("Welcome to Big Mammas Pizza Take Away");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * *");


            Pizza pizza1 = new Pizza(1, "Calzone", 80);
            Pizza pizza2 = new Pizza(2, "Hawaii", 70);
            Pizza pizza3 = new Pizza(3, "Ham", 60);

            Customer customer1 = new Customer("Peter", "Holbæk", 12345678);
            Customer customer2 = new Customer("Morten", "Roskilde", 87654321);
            Customer customer3 = new Customer("Paprika", "Hårlev", 13245768);

            Order order1 = new Order(1, customer1, pizza1);

            Order order2 = new Order(2, customer2, pizza2);

            Order order3 = new Order(3, customer3, pizza3);

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

