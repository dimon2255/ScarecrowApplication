namespace ScarecrowApplication
{
    public class BankingInfo
    {
        public FundingMethod FundingMethod { get; set; }
        public decimal AccountNumber { get; set; }
        public decimal SortCode { get; set; }
        public string Country { get; set; }
        public string TapeId { get; set; }
    }
}
