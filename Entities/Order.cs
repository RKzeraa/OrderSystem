class Order
{

    public Client Client { get; set; }
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }

    public List<OrderItem> Itens { get; set; }

    public Order()
    {
    }

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

    public double Total()
    {
        double sum = 0.00;
        foreach (OrderItem item in Itens)
        {
            sum += item.SubTotal();
        }

        return sum;
    }

    public string ShowOrderItens() {
        string showItens = "";
        foreach (OrderItem item in Itens)
        {
           showItens += item.ToString() + "\n";
        }
        return showItens;
    }

    public override string ToString()
    {
        return "\nORDER SUMMARY:\n"
                + $"Order moment: {Moment.ToString("MM/dd/yyyy HH:mm:ss")}"
                + $"\nOrder status: {Status}"
                + $"\nClient: {Client.ToString()}"
                + $"\nOrder items: \n{ShowOrderItens()}"
                + $"Total price: ${Total().ToString("F")}";
    }
}