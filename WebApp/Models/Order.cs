namespace WebApp.Models
{
    public class Order
    {
        public Order()
        { 
            OrderItems = new List<OrderItem>();
        }
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string? UserId { get; set; }
        public AppUser User { get; set; }
        public decimal TotalAmount { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
