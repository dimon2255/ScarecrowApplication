namespace ScarecrowApplication
{
    public class BusinessInfo
    {
        public string DbaName { get; set; }
        public string DbaNameExtended { get; set; }
        public Address BusinessAddress { get; set; }
        public string LegalName { get; set; }
        public string LegalNameExtended { get; set; }
        public BusinessInfoAdditionalAddresses AdditionalAddresses { get; set; }
        public string TaxID { get; set; }
        public string ProductDescription { get; set; }
        public string MccCode { get; set; }
        public decimal EstablishmentYear { get; set; }
    }
}
