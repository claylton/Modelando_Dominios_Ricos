namespace PaymentContext.Domain.Entities
{
    class Subscription
    {
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public DateTime? ExtirateDate { get; set; }
        public bool Active { get; set; }
        public List<Payment> Payments { get; set; }
    }
}

//DateTime? == Valor null
