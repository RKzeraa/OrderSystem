using System.Text;

class Order
{

    public Client Client { get; set; }
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public List<OrderItem> Itens { get; set; }

    public Order(Client client, OrderStatus status)
    {
        Client = client;
        Moment = DateTime.Now;
        Status = status;
        Itens = new List<OrderItem>();
    }

    public void AddItem(OrderItem item)
    {
        Itens.Add(item);
    }

    public void RemoveItem(OrderItem item)
    {
        Itens.Remove(item);
    }

    private double Total()
    {
        double sum = 0.00;
        foreach (OrderItem item in Itens)
        {
            sum += item.SubTotal();
        }

        return sum;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("\nORDER SUMMARY:");
        sb.Append("Order moment: ");
        sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
        sb.Append("Order status: ");
        sb.AppendLine(Status.ToString());
        sb.Append("Client: ");
        sb.AppendLine(Client.ToString());
        sb.AppendLine("Order items: ");
        foreach (OrderItem item in Itens)
        {
            sb.AppendLine(item.ToString());
        }
        sb.Append("Total price: ");
        sb.AppendLine(Total().ToString("C2"));

        return sb.ToString();
    }
}