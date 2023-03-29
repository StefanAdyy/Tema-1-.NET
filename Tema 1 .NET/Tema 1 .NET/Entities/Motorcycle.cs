namespace Tema_1_.NET.Entities
{
    public class Motorcycle
    {
        public int Id { get; set; }
        public int ManufacturerId { get; set; }
        public string Model { get; set; } = String.Empty;
        public int Year { get; set; }
        public int HorsePower { get; set; }
        public int Torque { get; set; }
        public int EngineDisplacement { get; set; }
        public int TankCapacity { get; set; }
    }
}
