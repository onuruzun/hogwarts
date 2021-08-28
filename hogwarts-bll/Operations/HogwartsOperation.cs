using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using hogwarts_bll.Models;
using hogwarts_bll.Models.Dto;
using hogwarts_bll.Models.Request;
using hogwarts_repository.Models;
using hogwarts_repository.Repositories.HouseRepository.Interfaces;

namespace hogwarts_bll.Operations
{
    public class HogwartsOperation : IHogwartsOperation
    {
        private readonly IHouseRepository _houseRepository;
        private readonly IMapper _mapper;
        public HogwartsOperation(IHouseRepository houseRepository,
            IMapper mapper)
        {
            _houseRepository = houseRepository;
            _mapper = mapper;
        }

        public async Task<HogwartsDto> GetHouses()
        {
            var result = await _houseRepository.GetHouses();

            if (result == null)
                return null;

            var houses = _mapper.Map<List<HouseModel>>(result);

            return new HogwartsDto
            {
                Houses = houses
            };
        }

        public async Task<HouseModel> GetHouse(int id)
        {
            var result = await _houseRepository.GetById(id);

            if (result == null)
                return null;

            var house = _mapper.Map<HouseModel>(result);

            return house;
        }


        public async Task<bool> NewHouse(NewHouse model)
        {
            var house = _mapper.Map<House>(model);

            var result = await _houseRepository.Create(house);

            return result;
        }

        public async Task<bool> UpdateHouse(UpdateHouse model)
        {
            var isExist = await _houseRepository.GetById(model.Id);
            if (isExist == null)
                return false;

            var house = _mapper.Map<House>(model);

            var result = await _houseRepository.Update(house);

            return result;
        }

        public async Task<bool> DeleteHouse(int id)
        {
            var isExist = await _houseRepository.GetById(id);
            if (isExist == null)
                return false;

            var result = await _houseRepository.Delete(id);

            return result;
        }
    }
}