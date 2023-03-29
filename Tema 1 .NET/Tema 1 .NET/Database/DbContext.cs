using Tema_1_.NET.Entities;

namespace Tema_1_.NET.Database
{
    public static class DbContext
    {
        public static List<Motorcycle> Motorcycles = new List<Motorcycle>
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
    }
}
