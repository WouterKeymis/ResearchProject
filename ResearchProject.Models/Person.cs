using System;
using System.Collections.Generic;

namespace ResearchProject.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public bool Married { get; set; }
        public DateTime CustomerSince { get; set; }

        public ICollection<Address> Addresses { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}