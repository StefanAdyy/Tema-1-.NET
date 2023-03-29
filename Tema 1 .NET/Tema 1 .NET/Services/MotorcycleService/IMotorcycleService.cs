using Tema_1_.NET.Entities;

namespace Tema_1_.NET.Services.MotorcycleService
{
    public interface IMotorcycleService
    {
        Task<List<Motorcycle>> GetAllMotorcycles();
        Task<Motorcycle?> GetMotorcycleById(int id);
        Task<List<Motorcycle>?> AddMotorcycle(Motorcycle motorcycle);
        Task<List<Motorcycle>?> UpdateMotorcycle(Motorcycle request);
        Task<List<Motorcycle>?> DeleteMotorcycle(int id);
    }
}
