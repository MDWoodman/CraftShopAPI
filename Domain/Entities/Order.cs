namespace CraftShopAPI.Domain.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string ShippingAddress { get; set; }
        public decimal TotalAmount { get; set; }
        public List<int> ProductsId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
    }
}
