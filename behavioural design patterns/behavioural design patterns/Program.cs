using behavioural_design_patterns;

Order order = new Order("123");

Customer customer1 = new Customer("custome r1@example.com", "+123456789");
Customer customer2 = new Customer("customer2@example.com", "+987654321");
Staff staff1 = new Staff("Staff A");
Staff staff2 = new Staff("Staff B");

order.Attach(customer1);
order.Attach(customer2);
order.Attach(staff1);
order.Attach(staff2);

order.UpdateStatus("Processing");
order.UpdateStatus("Shipped");

order.Detach(customer2);

order.UpdateStatus("Delivered");