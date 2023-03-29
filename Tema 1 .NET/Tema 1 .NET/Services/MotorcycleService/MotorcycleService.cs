using Tema_1_.NET.Entities;
using Tema_1_.NET.Repositories;

namespace Tema_1_.NET.Services.MotorcycleService
{
    public class MotorcycleService : IMotorcycleService
    {
        private readonly MotorcycleRepository _motorcycleRepository;
        public MotorcycleService(MotorcycleRepository motorcycleRepository)
        {
            _motorcycleRepository = motorcycleRepository;
        }

        public async Task<List<Motorcycle>> AddMotorcycle(Motorcycle motorcycle)
        {
            _motorcycleRepository.AddMotorcycle(motorcycle);
            return _motorcycleRepository.GetAllMotorcycles();
        }

        public async Task<List<Motorcycle>?> DeleteMotorcycle(int id)
        {
            var result = _motorcycleRepository.GetMotorcycleById(id);

            if (result is null)
            {
                return null;
            }

            _motorcycleRepository.DeleteMotorcycle(id);

            return _motorcycleRepository.GetAllMotorcycles();
        }

        public async Task<List<Motorcycle>> GetAllMotorcycles()
        {
            return _motorcycleRepository.GetAllMotorcycles();
        }

        public async Task<Motorcycle?> GetMotorcycleById(int id)
        {
            var result = _motorcycleRepository.GetMotorcycleById(id);

            if (result is null)
            {
                return null;
            }

            return result;
        }

        public async Task<List<Motorcycle>?> UpdateMotorcycle(Motorcycle request)
        {
            var result = _motorcycleRepository.GetMotorcycleById(request.Id);

            if (result is null)
            {
                return null;
            }

            result.ManufacturerId = request.ManufacturerId;
            result.Model = request.Model;
            result.Year = request.Year;
            result.HorsePower = request.HorsePower;
            result.Torque = request.Torque;
            result.EngineDisplacement = request.EngineDisplacement;
            result.TankCapacity = request.TankCapacity;

            return _motorcycleRepository.GetAllMotorcycles();
        }
    }
}
