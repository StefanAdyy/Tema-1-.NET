using System;
using Tema_1_.NET.Database;
using Tema_1_.NET.Entities;

namespace Tema_1_.NET.Repositories
{
    public class MotorcycleRepository
    {
        public void AddMotorcycle(Motorcycle motorcycle)
        {
            DbContext.Motorcycles.Add(motorcycle);
        }

        public void DeleteMotorcycle(int id)
        {
            var result = DbContext.Motorcycles.Find(x => x.Id == id);
            DbContext.Motorcycles.Remove(result);
        }

        public List<Motorcycle> GetAllMotorcycles()
        {
            var result = DbContext.Motorcycles;
            return result;
        }

        public Motorcycle? GetMotorcycleById(int id)
        {
            var result = DbContext.Motorcycles.Find(x => x.Id == id);
            return result;
        }

        public void UpdateMotorcycle(Motorcycle request)
        {
            var motorcycle = DbContext.Motorcycles.Find(x => x.Id == request.Id);

            if (motorcycle is not null)
            {
                motorcycle.ManufacturerId = request.ManufacturerId;
                motorcycle.Model = request.Model;
                motorcycle.Year = request.Year;
                motorcycle.HorsePower = request.HorsePower;
                motorcycle.Torque = request.Torque;
                motorcycle.EngineDisplacement = request.EngineDisplacement;
                motorcycle.TankCapacity = request.TankCapacity;
            }
        }
    }
}
