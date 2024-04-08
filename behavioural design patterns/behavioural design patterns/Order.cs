namespace behavioural_design_patterns;

public class Order : IOrderSubject
{
    private List<IOrderObserver> _observers = new List<IOrderObserver>();
    public string OrderId { get; }
    public string Status { get; private set; }

    public Order(string orderId)
    {
        OrderId = orderId;
        Status = "New";
    }

    public void Attach(IOrderObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IOrderObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }

    public void UpdateStatus(string newStatus)
    {
        Status = newStatus;
        Console.WriteLine($"Order {OrderId} status updated: {Status}");
        Notify();
    }
}
