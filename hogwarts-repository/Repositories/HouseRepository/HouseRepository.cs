using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hogwarts_repository.Context;
using hogwarts_repository.Generic;
using hogwarts_repository.Models;
using hogwarts_repository.Repositories.HouseRepository.Interfaces;

namespace hogwarts_repository.Repositories.HouseRepository
{
    public class HouseRepository : GenericRepository<House>, IHouseRepository
    {
        public HouseRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {

        }
        public Task<List<House>> GetHouses()
        {
            var result = GetAll().ToList();

            return Task.FromResult<List<House>>(result);
        }
    }
}