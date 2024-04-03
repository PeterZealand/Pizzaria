using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class Store
    {
        #region Instance fields


        #endregion

        #region Constructor
        public MenuCatalog menuCatalog = new MenuCatalog();
        #endregion

        #region Properties

        #endregion


        #region Methods

        public void Start()
        {
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("Welcome to Big Mammas Pizza Take Away");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * *");



            
            Pizza pizza1 = new Pizza("Margherita", 80);
            Pizza pizza2 = new Pizza("Vesuvio", 92);
            Pizza pizza3 = new Pizza("Capricciosa", 98);
            Pizza pizza4 = new Pizza("Calzone (Indbagt pizza)", 98);
            Pizza pizza5 = new Pizza("Quattro Stagioni", 98);
            Pizza pizza6 = new Pizza("Matinara", 97);
            Pizza pizza7 = new Pizza("Vegetariana", 98);
            Pizza pizza8 = new Pizza("Italiana", 93);
            Pizza pizza9 = new Pizza("Gorgonzola", 97);
            Pizza pizza10 = new Pizza("Contadina", 92);

            //TODO kan pizza "create" flyttes så den automatisk sker når der oprettes en pizza
            menuCatalog.Create(pizza1);
            menuCatalog.Create(pizza2);
            menuCatalog.Create(pizza3);
            menuCatalog.Create(pizza4);
            menuCatalog.Create(pizza5);
            menuCatalog.Create(pizza6);
            menuCatalog.Create(pizza7);
            menuCatalog.Create(pizza8);
            menuCatalog.Create(pizza9);
            menuCatalog.Create(pizza10);

            
        }
        public void UI()
        {
            new UserDialog(menuCatalog).UI();
        }
        #endregion

    }
}
