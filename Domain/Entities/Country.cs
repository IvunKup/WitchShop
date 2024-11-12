namespace Domain.Entities
{
    public class Country
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public ICollection<Drug> Drugs { get; set; }
    }
}