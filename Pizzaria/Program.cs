namespace Pizzaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.Start();



            store.UI();


            Console.WriteLine();
            Console.WriteLine("Press any key to close the program...");

            Console.ReadKey();
            
        }
    }
}
