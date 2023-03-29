using Tema_1_.NET.Entities;

namespace Tema_1_.NET.Services.MotorcycleService
{
    public interface IMotorcycleService
    {
        List<Motorcycle> GetAllMotorcycles();
        Motorcycle? GetMotorcycleById(int id);
        List<Motorcycle> AddMotorcycle(Motorcycle motorcycle);
        List<Motorcycle>? UpdateHero(Motorcycle request);
        List<Motorcycle>? DeleteMotorcycle(int id);
    }
}
