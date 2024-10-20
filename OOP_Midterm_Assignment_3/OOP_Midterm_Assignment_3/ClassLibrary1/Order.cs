namespace ClassLibrary1
{
    public class Order
    {
        public int OrderId { get; set; }
        public string? Product { get; set; } 
        public double Price { get; set; }
 
        public Order() {}
 
        public Order(int orderId, string product, double price)
        {
            OrderId = orderId;
            Product = product;
            Price = price;
        }
    }
}
