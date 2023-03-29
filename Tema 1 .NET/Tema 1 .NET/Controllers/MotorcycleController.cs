using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tema_1_.NET.Entities;
using Tema_1_.NET.Services.MotorcycleService;

namespace Tema_1_.NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorcycleController : ControllerBase
    {
        private readonly IMotorcycleService _motorcycleService;
        public MotorcycleController(IMotorcycleService motorcycleService)
        {
            _motorcycleService = motorcycleService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Motorcycle>>> GetAllMotorcycles()
        {
            return _motorcycleService.GetAllMotorcycles();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Motorcycle>> GetMotorcycleById(int id)
        {
            var result = _motorcycleService.GetMotorcycleById(id);

            if(result is null)
            {
                return NotFound("Sorry, this motorcycle doesn't exist");
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Motorcycle>>> AddMotorcycle(Motorcycle motorcycle)
        {
            var result = _motorcycleService.AddMotorcycle(motorcycle);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<List<Motorcycle>>> UpdateMotorcycle(Motorcycle request)
        {
            var result = _motorcycleService.UpdateMotorcycle(request);

            if (result is null)
            {
                return NotFound("Sorry, this motorcycle doesn't exist");
            }
            
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Motorcycle>> DeleteMotorcycle(int id)
        {
            var result = _motorcycleService.DeleteMotorcycle(id);

            if (result == null)
            {
                return NotFound("Sorry, this motorcycle doesn't exist");
            }

            return Ok(result);
        }
    }
}
