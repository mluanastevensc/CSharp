using System;
namespace FactoryParttern
{
    public class Car: IVehicle
    {
        public Car()
        {
        }
        public void Drive()
        {
            Console.WriteLine("The car is driving!");
        }
    }
}
