using System.Globalization;

class Program
{
    static void Main(string[] agrs)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Enter cliente data:");
        Console.ResetColor();
        Console.Write("\nName: ");
        Console.ForegroundColor = ConsoleColor.Red;
        string name = Console.ReadLine()!;
        Console.ResetColor();

        Console.Write("Email: ");
        Console.ForegroundColor = ConsoleColor.Red;
        string email = Console.ReadLine()!;
        Console.ResetColor();

        Console.Write("Birth date (DD/MM/YYYY): ");
        Console.ForegroundColor = ConsoleColor.Red;
        string birthDate = Console.ReadLine()!;
        Console.ResetColor();

        Client client = new Client(name, email, birthDate);

        Console.Write("Enter order data: \nStatus: ");

        Console.ForegroundColor = ConsoleColor.Red;
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()!);
        Console.ResetColor();

        Order order = new Order(client, status);

        Console.Write("How many items to this order? ");
        Console.ForegroundColor = ConsoleColor.Red;
        int n = int.Parse(Console.ReadLine()!);
        Console.ResetColor();

        string productName;
        double price;
        int quantity;
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter #{i + 1} item data: \nProduct name: ");
            Console.ForegroundColor = ConsoleColor.Red;
            productName = Console.ReadLine()!;
            Console.ResetColor();

            Console.Write("Product price: ");
            Console.ForegroundColor = ConsoleColor.Red;
            price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture); //*If removed CultureInfo the code is broken!
            Console.ResetColor();

            Console.Write("Quantity: ");
            Console.ForegroundColor = ConsoleColor.Red;
            quantity = int.Parse(Console.ReadLine()!);
            Console.ResetColor();

            Product product = new Product(productName, price);
            OrderItem orderItem = new OrderItem(product, quantity, price);
            order.AddItem(orderItem);
        }

        Console.WriteLine(order.ToString());
    }
}