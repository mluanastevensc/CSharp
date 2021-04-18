using System;
namespace FactoryParttern
{
    public class VehicleFactory
    {
        
        public static IVehicle GetVehicle(int WheelCount)
        {
            switch (WheelCount)
            {
                case 4:
                    return new Car();
                case 2:
                    return new Motorcycle();
                default:
                    return new Car();
            }
        }
    }
}
