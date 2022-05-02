using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResearchProject.Models;

namespace ResearchProject.DAL
{
    public interface IVetenaryRepository
    {
        Task<Veterinary> GetVetByPetId(int petId);
    }
}
