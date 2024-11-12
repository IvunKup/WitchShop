namespace Domain.Entities
{
    public class Drug : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufactorer { get; set; }
        public string CountryCodeId { get; set; }
        public Country Country { get; set; }
    }
}