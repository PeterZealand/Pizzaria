using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        //if a dictionary is used
        //private Dictionary<int, Pizza> _pizzas = new Dictionary<int, Pizza>();
        //_pizzas.Add(Pizza._menuNumber, pizza);
        private List<Pizza> _pizzas = new List<Pizza>();

        public void Create(Pizza pizza)
        {
        //List:
        _pizzas.Add(pizza);
            
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
                //{_pizzas.IndexOf(p)} also a way to do it but starts at count 0. 
            }

        }


        public Pizza Search(int number)
        {
                foreach (Pizza p in _pizzas)
                {
                    if (p.MenuNumber == number)
                    {
                        return p;
                    }
                }
            {
                throw new FormatException($"No pizza found with menu number {number}");
            }
        }

        public Pizza DeletePizza(int number) 
        {
            
                bool deletion = false;
                foreach (Pizza p in _pizzas)
                {
                    if (p.MenuNumber == number)
                    {
                        _pizzas.Remove(p);


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
                if (!deletion)
                {
                    throw new FormatException($"No pizza found with menu number {number}");
                }
                //TODO is not caught anymore standart message is shown when anything other than a number is the input
                //else
                //{
                //    throw new FormatException($"Search must be a number");
                //}
            return null;
                
        }

        public Pizza Update(int number)
        {
            
                foreach (Pizza p in _pizzas)
                {
                    if (p.MenuNumber == number)
                    {
                        //Console.WriteLine("Input new Pizza name");
                        //p.PizzaName = Console.ReadLine();
                        //Console.WriteLine("Input new Pizza price");
                        //p.Price = int.Parse(Console.ReadLine());
                        return p;
                    }
                
                }
            {
                throw new FormatException($"No pizza found with menu number {number}");
            }
           
        }

        public Pizza NewPizza(Pizza pizza)
        {
                bool creation = false;

                if (pizza.Price >= 1 && pizza.Price <= 200)
                {
                    
                    _pizzas.Add(pizza);
                    creation = true;

                    if (creation)
                    {
                        Pizza.Reset();
                        foreach (Pizza p in _pizzas)
                        {
                            p.MenuNumber = Pizza.MenuNumbers();
                        }
                    return pizza;
                    }
                
                }
                else if (pizza.Price < 1 || pizza.Price > 200)
                {
                    throw new FormatException("Price must be a number between 1 and 200.");
                }
                //incorporated into one else if
                //else if (pizza.Price > 200)
                //{
                //    throw new FormatException("Price must be less than or equal to 200.");
                //}
                //does not work after moving writelines to UserDialog
                //else
                //{
                //    throw new Exception("Price cannot be a Letter, Price must be a number between 1 and 200.");
                //}
        
            return null;
        }

        #endregion
    }
}
