using ClassLibrary1; 
 
namespace ClassLibrary1 
{
    public class OrderProcessor
    {
        private EmailSender emailSender;
 
        public OrderProcessor(EmailSender emailSender)
        {
            this.emailSender = emailSender;
        }
 
        public bool ProcessOrder(Order order)
        {
            return emailSender.SendEmail("customer@example.com", "Order Confirmation",
                $"Order {order.OrderId} processed.");
        }
    } 
} 
