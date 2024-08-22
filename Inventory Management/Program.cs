// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
internal class Program
{
    private static void Main(string[] args)
    {
        bool exit = false;

        do
        {
            Console.WriteLine("Hello ! Please Enter Your Choice");
            Console.WriteLine("1.Add new product ");
            Console.WriteLine("2.View all products ");
            Console.WriteLine("==> Your Choice : ");

            string? choice = Console.ReadLine();
            menu(choice);
        }
        while (!exit);


        void menu(string choice)
        {
            switch (choice)
            {
                case "1":
                    Inventory.AddProduct();
                    break;
                case "2":
                    Inventory.ViewAllProducts();
                    break;
                case "5":
                    exit = true; break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }
}