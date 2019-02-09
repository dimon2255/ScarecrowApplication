namespace ScarecrowApplication
{
    public class ScarecrowApplication
    {
        public string UniqueId { get; set; }
        public Principle Principle { get; set; }
        public BusinessInfo BusinessInfo { get; set; }
        public Contact Contact { get; set; }
        public ScarecrowApplicationBankAccounts BankAccounts { get; set; }
        public ScarecrowApplicationDistributions Distributions { get; set; }
    }
}
