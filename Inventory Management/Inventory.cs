//namespace Inventory_Management {
public class Inventory
{
    private static List<Product> Products = new();
    private static int GetInt(string question)
    {
        int result = 0;
        bool validInput = false;

        while (!validInput)
        {
            Console.WriteLine(question);
            string? input = Console.ReadLine();

            if(input==null) { Console.WriteLine("Invalid input. Please enter a valid number."); }
            else{
            try
            {
                result = Convert.ToInt32(input);
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }}
        }

        return result;
    }


    public static void AddProduct()
    {
        int id = GetInt("Enter Product ID :");
        Console.WriteLine("Enter Product name :");
        string? name = Console.ReadLine();
        int price = GetInt("Enter Product price :");
        int quantity = GetInt("Enter Product quantity :");
        if (id == 0 || price == 0 || quantity == 0 || name == null) { Console.WriteLine("Failed to Add Product"); }
        else
        {
            Product p = new Product(id, name, price, quantity);
            Products.Add(p);
        }
    }

    public static void ViewAllProducts()
    {
        foreach (var item in Products)
        {
            Console.WriteLine($"ID: {item.Id},  Name: {item.Name},  Price: {item.Price},  Quantity: {item.Quantity}");
        }
    }

}