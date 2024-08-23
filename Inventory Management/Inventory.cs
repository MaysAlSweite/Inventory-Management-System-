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

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            else
            {
                try
                {
                    result = Convert.ToInt32(input);
                    if (result != 0)
                    { validInput = true; }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        return result;
    }
    private static string GetName()
    {
        string name;

        do
        {
            Console.WriteLine("Enter Product name:");
            name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name) || ProductExists(name))
            {
                Console.WriteLine("Name is null or already exists. Please enter another name.");
                name = "error";
            }
        } while (name == "error");

        return name;
    }

    private static bool ProductExists(string name)
    {
        foreach (var item in Products)
        {
            if (item.Name == name)
            {
                return true;
            }
        }
        return false;
    }

    public static void AddProduct()
    {
        int id = GetInt("Enter Product ID :");
        string name = GetName();
        int price = GetInt("Enter Product price :");
        int quantity = GetInt("Enter Product quantity :");

        if (name != "error")
        {
            Product p = new Product(id, name, price, quantity);
            Products.Add(p);
            Console.WriteLine("Product added successfully");
        }
        else { Console.WriteLine("Failed to add product"); }
    }

    public static void ViewAllProducts()
    {
        if (Products.Count == 0)
        {
            Console.WriteLine("No products in inventory.");
            return;
        }
        foreach (var item in Products)
        {
            Console.WriteLine($"ID: {item.Id},  Name: {item.Name},  Price: {item.Price},  Quantity: {item.Quantity}");
        }
    }

    public static void EditProduct()
    {
        Console.WriteLine("Enter Product name :");
        string? name = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(name))
        {
            foreach (var item in Products)
            {
                if (item.Name == name)
                {
                    //product exists
                    Console.WriteLine($"Editing product: {item.Name}");
                    string newName = GetName();
                    if (newName != "error")
                    {
                        item.Name = newName;
                        item.Price = GetInt($"Current product price: {item.Price}\nEnter the new price:");
                        item.Quantity = GetInt($"Current product quantity: {item.Quantity}\nEnter the new quantity:");
                        Console.WriteLine("Product edited successfully");
                    }
                    else
                    {
                        Console.WriteLine(" Edit process failed");
                        //break
                    }
                }
                else
                {
                    Console.WriteLine("Product doesn't exist in the inventory, Edit process failed");
                    //break }
                }
            }
        }

    }
}