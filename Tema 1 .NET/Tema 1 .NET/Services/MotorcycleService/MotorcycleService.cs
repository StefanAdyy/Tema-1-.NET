using Tema_1_.NET.Entities;

namespace Tema_1_.NET.Services.MotorcycleService
{
    public class MotorcycleService : IMotorcycleService
    {
         private static List<Motorcycle> motorcycleList = new List<Motorcycle>
        {
            new Motorcycle
                {
                    Id = 1,
                    ManufacturerId = 1,
                    Model = "GSX-R 1000",
                    Year = 2009,
                    HorsePower = 185,
                    Torque = 117,
                    EngineDisplacement = 999,
                    TankCapacity = 17
                },
                new Motorcycle
                {
                    Id = 2,
                    ManufacturerId = 1,
                    Model = "GS 500 F",
                    Year = 2006,
                    HorsePower = 47,
                    Torque = 41,
                    EngineDisplacement = 487,
                    TankCapacity = 20
                }
        };

        public List<Motorcycle> AddMotorcycle(Motorcycle motorcycle)
        {
            motorcycleList.Add(motorcycle);
            return motorcycleList;
        }

        public List<Motorcycle>? DeleteMotorcycle(int id)
        {
            var motorcycle = motorcycleList.Find(x => x.Id == id);

            if (motorcycle is null)
            {
                return null;
            }

            motorcycleList.Remove(motorcycle);
            return motorcycleList;
        }

        public List<Motorcycle> GetAllMotorcycles()
        {
            return motorcycleList;
        }

        public Motorcycle? GetMotorcycleById(int id)
        {
            var motorcycle = motorcycleList.Find(x => x.Id == id);

            if (motorcycle is null)
            {
                return null;
            }

            return motorcycle;
        }

        public List<Motorcycle>? UpdateHero(Motorcycle request)
        {
            var motorcycle = motorcycleList.Find(x => x.Id == request.Id);

            if (motorcycle is null)
            {
                return null;
            }

            motorcycle.ManufacturerId = request.ManufacturerId;
            motorcycle.Model = request.Model;
            motorcycle.Year = request.Year;
            motorcycle.HorsePower = request.HorsePower;
            motorcycle.Torque = request.Torque;
            motorcycle.EngineDisplacement = request.EngineDisplacement;
            motorcycle.TankCapacity = request.TankCapacity;

            return motorcycleList;
        }
    }
}
