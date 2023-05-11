using System.Globalization;

class Program
{
    static void Main(string[] agrs)
    {

        Console.Write("Enter cliente data:");
        Console.Write("\nName: ");
        string name = Console.ReadLine()!;

        Console.Write("Email: ");
        string email = Console.ReadLine()!;

        Console.Write("Birth date (DD/MM/YYYY): ");
        string birthDate = Console.ReadLine()!;

        Client client = new Client(name, email, birthDate);

        Console.Write("Enter order data: \nStatus: ");

        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()!);
        
        Order order = new Order(client, status);
        Console.Write("How many items to this order? ");
        int n = int.Parse(Console.ReadLine()!);
        string productName;
        double price;
        int quantity;
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter #{i+1} item data: \nProduct name: ");
            productName = Console.ReadLine()!;
            Console.Write("Product price: ");
            price = double.Parse(Console.ReadLine()!, CultureInfo.GetCultureInfo("en-US"));
            Console.Write("Quantity: ");
            quantity = int.Parse(Console.ReadLine()!);
            Product product = new Product(productName, price);
            OrderItem orderItem = new OrderItem(product, quantity, price);
            order.AddItem(orderItem);
        }

        Console.WriteLine(order.ToString());
    }
}