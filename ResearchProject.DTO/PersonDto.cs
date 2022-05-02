using System;

namespace ResearchProject.DTO
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public bool Married { get; set; }
        public DateTime CustomerSince { get; set; }
    }
}