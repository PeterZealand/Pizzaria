using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class MenuCatalog
    {
        #region Instance fields
        

        #endregion

        #region Constructor
         
        #endregion

        #region Properties

        #endregion

        #region collections
        //private Dictionary<int, Pizza> _pizzas = new Dictionary<int, Pizza>();

        private List<Pizza> _pizzas = new List<Pizza>();

        public void Create(Pizza pizza)
        {
        //List:
        _pizzas.Add(pizza);
            //_pizzas.Add(Pizza._menuNumber, pizza);

        }

        #endregion

        #region Methods


        public void PrintMenu()
        {
            Console.WriteLine("********************************+");
            Console.WriteLine("*--------Big Mamma Pizza--------*");
            Console.WriteLine("*********************************");
            foreach (Pizza p in _pizzas) 
            {
                 Console.WriteLine($"{p}");
                //{_pizzas.IndexOf(p)} . 
            }

        }


        public Pizza Search(int number)
        {
            try
            {

                foreach (Pizza p in _pizzas)
                {
                    if (p.MenuNumber == number)
                    {
                        Console.WriteLine($"Nr: {p.MenuNumber}\nName: {p.PizzaName} \nPrice: {p.Price}");

                        return p;
                    }

                }
                throw new Exception($"No pizza found with menu number {number}");
                    }
                    //catch (FormatException e)
                    //{
                    //    Console.WriteLine(e.Message);
                    //}
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
            }
            return null;
        }

        public Pizza DeletePizza(int number) 
        {
            try
            {
                bool deletion = false;
                foreach (Pizza p in _pizzas)
                {
                    if (p.MenuNumber == number)
                    {
                        _pizzas.Remove(p);
                        Console.WriteLine($"You deleted pizza no. {p.MenuNumber}. {p.PizzaName}");

                        deletion = true;

                        if (deletion)
                        {
                            Pizza.Reset();
                            foreach (Pizza pi in _pizzas)
                            {
                                pi.MenuNumber = Pizza.MenuNumbers();
                            }
                        }
                        return p;
                    }
                }
                throw new Exception($"No pizza found with menu number {number}");
            }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    
                    }
            return null;
            

        }
        public Pizza Update(int number)
        {
            try
            {
                foreach (Pizza p in _pizzas)
                {
                    if (p.MenuNumber == number)
                    {
                        Console.WriteLine("Input new Pizza name");
                        p.PizzaName = Console.ReadLine();
                        Console.WriteLine("Input new Pizza price");
                        p.Price = int.Parse(Console.ReadLine());
                        return p;
                    }

                }
            
                throw new Exception($"No pizza found with menu number {number}");
            }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Pizza not updated. {e.Message}");
                }
            return null;
        }

        public Pizza NewPizza(Pizza pizza)
        {
            //try
            //{
                Console.WriteLine("Input Pizza name:");
                pizza.PizzaName = Console.ReadLine();

                Console.WriteLine("Input Pizza price (between 1 and 200):");
                int price;
                bool isValidPrice = int.TryParse(Console.ReadLine(), out price);

                if (isValidPrice && price >= 1 && price <= 200)
                {
                    pizza.Price = price;
                    _pizzas.Add(pizza);
                    return pizza;
                }
                else if (isValidPrice && price < 1)
                {
                    throw new FormatException("Price must be greater than or equal to 1.");
                }
                else if (isValidPrice && price > 200)
                {
                    throw new FormatException("Price must be less than or equal to 200.");
                }
                else
                {
                    throw new FormatException("Price must be a number between 1 and 200.");
                }
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //return null;
        }

      

        //Console.WriteLine("Input new Pizza name"),
        //string UserUpdateName = Console.ReadLine();
        //Console.WriteLine("Input new Pizza price");

        //public int MenuChoise() 
        //{
        //    public int MenuChoice(List<string> menuItems)
        //    { return 0 ; }

        //}

        //public override string ToString()
        //{
        //    return $"Nr.{MenuNumber}: ";
        //}
        #endregion
    }
}
