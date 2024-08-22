public class Product
{
    private int id;
    private string name;
    private int price;
    private int quantity;

    public Product(int id, string name, int price, int quantity)
    {
        this.id = id;
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    public int Id { get; set; }
    public string Name
    {
        get { return name; }
        set
        {
            name = value.Length > 15 ? value[..15] : value;
        }
    }
    public int Price { get; set; }
    public int Quantity { get; set; }

}