namespace CraftShopAPI.Domain.Entities
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string BillingAddress { get; set; }
        public decimal TotalAmount { get; set; }
        public int OrderId { get; set; }
    }
}
