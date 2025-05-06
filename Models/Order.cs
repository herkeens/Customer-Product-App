namespace CustomerProductOrderApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public string ProductName { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
