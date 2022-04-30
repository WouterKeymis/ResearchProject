namespace ResearchProject.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public Person Person { get; set; }
    }
}