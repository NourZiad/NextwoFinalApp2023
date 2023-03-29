namespace NextwoFirstApp2023.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public string? InvoiceId { get; set; }

        public string? Total { get; set;}

        public bool IsSuccess{ get; set; }
    }
}
