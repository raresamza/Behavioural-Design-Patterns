namespace behavioural_design_patterns;

public class Staff : IOrderObserver
{
    public string Name { get; }

    public Staff(string name)
    {
        Name = name;
    }

    public void Update(Order order)
    {
        Console.WriteLine($"Notification sent to staff {Name}: New order {order.OrderId} received, status: {order.Status}");
    }
}
