using System.Collections.Generic;
using System.Threading.Tasks;
using hogwarts_repository.Generic;
using hogwarts_repository.Models;

namespace hogwarts_repository.Repositories.HouseRepository.Interfaces
{
    public interface IHouseRepository : IRepository<House>
    {
        Task<List<House>> GetHouses();
    }
}