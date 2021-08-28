using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using hogwarts_bll;
using hogwarts_bll.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace hogwarts_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HogwartsController : ControllerBase
    {
        private readonly IHogwartsOperation _hogwartsOperation;
        public HogwartsController(IHogwartsOperation hogwartsOperation)
        {
            _hogwartsOperation = hogwartsOperation;
        }

        [HttpGet]
        [Route("Houses")]
        public async Task<IActionResult> Get()
        {
            var response = await _hogwartsOperation.GetHouses();

            return Ok(response);
        }

        [HttpGet("House/{id}")]
        public async Task<IActionResult> Get([Required] int id)
        {
            var response = await _hogwartsOperation.GetHouse(id);

            return Ok(response);
        }

        [HttpPost]
        [Route("House")]
        public async Task<IActionResult> New([Required, FromBody] NewHouse house)
        {
            var response = await _hogwartsOperation.NewHouse(house);

            return Ok(response);
        }

        [HttpPut]
        [Route("House")]
        public async Task<IActionResult> Update([Required, FromBody] UpdateHouse house)
        {
            var response = await _hogwartsOperation.UpdateHouse(house);

            return Ok(response);
        }

        [HttpDelete]
        [Route("House")]
        public async Task<IActionResult> Delete([Required] int id)
        {
            var response = await _hogwartsOperation.DeleteHouse(id);

            return Ok(response);
        }
    }
}