using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pizzaria
{
    public class UserDialog
    {
        MenuCatalog _menuCatalog;
        public UserDialog(MenuCatalog menuCatalog)
        {
            _menuCatalog = menuCatalog;
        }



        int AdminMenu(List<string> menuItems)
        {
            Console.Clear();
            Console.WriteLine("********************************+*");
            Console.WriteLine("*--------Big MammaS Pizza--------*");
            Console.WriteLine("**********************************");
            Console.WriteLine();
            Console.WriteLine("Pizzaria administration choises:");
            Console.WriteLine("---------------------------------");
            foreach (string choice in menuItems)
            {
                Console.WriteLine(choice);
            }

            Console.Write("Choose an operation: ");
            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = int.Parse(input);
                return result;
            }

            catch (FormatException)
            {
                Console.WriteLine($" - '{input}'is not a valid choise, Input must be a number between 1 and 6");
            }
            return -1;
        }
        public void UI()
        {
            bool run = true;
            List<string> UIlist = new List<string>()
            {
                "1. Show Menu",
                "2. Search Pizza",
                "3. Create new Pizza",
                "4. Update Pizza",
                "5. Delete Pizza",
                "6. Exit"
            };

            while (run)
            {
                int MenuChoice = AdminMenu(UIlist);
                Console.WriteLine();
                switch (MenuChoice)
                {
                    case 1: //Show Menu
                        Console.Clear();
                        _menuCatalog.PrintMenu();
                        Console.Write("Hit any key to return to Pizza administration");
                        Console.ReadKey();
                        break;
                    case 2: //Search Pizza
                        Console.Clear();
                        Console.WriteLine("search for pizza by menu number");
                        try
                        {
                            int UserChoise = int.Parse(Console.ReadLine());
                            _menuCatalog.Search(UserChoise);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Search must be a number");
                        }
                        Console.Write("Hit any key to return to Pizza administration");
                        Console.ReadKey();
                        break;
                    case 3: // Create new pizza
                        Console.Clear();
                        _menuCatalog.PrintMenu();
                        try
                        {
                            Console.WriteLine("Input Pizza name:");
                            string pizzaName = Console.ReadLine();
                            Console.WriteLine("Input Pizza price (between 1 and 200):");
                            int pizzaPrice = int.Parse(Console.ReadLine());
                            Pizza newPizza = new Pizza(pizzaName, pizzaPrice);
                            Pizza p = _menuCatalog.NewPizza(newPizza);
                            _menuCatalog.PrintMenu();
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        //catch (Exception e)
                        //{
                        //    Console.WriteLine(e.Message);
                        //}
                        Console.Write("Hit any key to return to Pizza administration");
                        Console.ReadKey();
                        break;
                    case 4: //update pizza
                        Console.Clear();
                        _menuCatalog.PrintMenu();
                        Console.WriteLine("Update Pizza by menu number");
                        try
                        {
                            int UserChoise3 = int.Parse(Console.ReadLine());
                            _menuCatalog.Update(UserChoise3);
                        }
                        catch(FormatException)
                        {

                        }
                        Console.Write("Hit any key to return to Pizza administration");
                        Console.ReadKey();
                        break;
                    case 5: // Delete Pizza
                        
                            Console.Clear();
                        _menuCatalog.PrintMenu();
                        Console.WriteLine("Delete Pizza by menu number");
                            try
                            {
                                int UserChoise2 = int.Parse(Console.ReadLine());
                                _menuCatalog.DeletePizza(UserChoise2);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Search must be a number");
                            }
                            Console.WriteLine();
                            Console.WriteLine("New menu:");
                            _menuCatalog.PrintMenu();
                            Console.WriteLine();
                            Console.Write("Hit any key to return to Pizza administration");
                            Console.ReadKey();

                        break;
                    case 6: // exit
                        run = false;
                        Console.WriteLine("Closing down Pizza administration");
                        break;
                    default:
                        Console.Write("Input must be a number between 1 and 6");
                        Console.ReadKey();
                        break;
                }
            }

        }
    }
}
