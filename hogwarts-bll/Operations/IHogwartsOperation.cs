using System.Collections.Generic;
using System.Threading.Tasks;
using hogwarts_bll.Models;
using hogwarts_bll.Models.Dto;
using hogwarts_bll.Models.Request;

namespace hogwarts_bll
{
    public interface IHogwartsOperation
    {
        Task<HogwartsDto> GetHouses();
        Task<HouseModel> GetHouse(int id);
        Task<bool> NewHouse(NewHouse model);
        Task<bool> UpdateHouse(UpdateHouse model);
        Task<bool> DeleteHouse(int id);
    }
}