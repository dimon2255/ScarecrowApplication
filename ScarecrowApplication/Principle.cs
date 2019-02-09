namespace ScarecrowApplication
{
    public class Principle
    {
        public Name Name { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public DobDateComponents Dob { get; set; }
        public DocumentaryInfo DocumentaryInfo { get; set; }
        public bool ResponsibleParty { get; set; }
        public string SelectedVerificationMentod { get; set; }
    }
}
