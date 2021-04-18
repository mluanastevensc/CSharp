using System;
namespace FactoryParttern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }
        public void Drive()
        {
            Console.WriteLine("The motocycle is rivving up");

        }
    }
}
