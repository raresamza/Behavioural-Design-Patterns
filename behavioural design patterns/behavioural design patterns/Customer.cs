using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioural_design_patterns
{
    public class Customer : IOrderObserver
    {
        public string Email { get; }
        public string PhoneNumber { get; }

        public Customer(string email, string phoneNumber)
        {
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public void Update(Order order)
        {
            Console.WriteLine($"Notification sent to customer {Email}/{PhoneNumber}: Order {order.OrderId} status updated to {order.Status}");
        }
    }
}
