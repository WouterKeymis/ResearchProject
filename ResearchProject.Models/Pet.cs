using System.Collections.Generic;

namespace ResearchProject.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AnimalType { get; set; }
        public Person Owner { get; set; }
        public Veterinary Veterinary { get; set; }
    }
}