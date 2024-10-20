using ClassLibrary1; 
 
namespace ClassLibrary1 // Namespace declaration
{
    public class Customer // Class declaration
    {
        private List<Order> orders; // List to hold orders
 
        public Customer() // Constructor
        {
            orders = new List<Order>(); // Initialize the order list
        }
 
        public void AddOrder(Order order) // Method to add an order
        {
            orders.Add(order); // Add order to the list
        }
 
        public List<Order> GetOrders() // get the list of orders
        {
            return orders; // Return the list of orders
        }
    } 
} 