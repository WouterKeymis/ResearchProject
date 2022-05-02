using AutoMapper;
using ResearchProject.DTO;
using ResearchProject.Models;

namespace ResearchProject.API.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonDto>();
            CreateMap<Address, AddressDto>();
            CreateMap<Pet, PetDto>();
            CreateMap<Veterinary, VeterinaryDto>();
        }
    }
}