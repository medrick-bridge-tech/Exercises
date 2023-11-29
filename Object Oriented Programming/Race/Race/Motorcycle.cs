using System;

namespace Race
{
    public class Motorcycle: Vehicle, IDriveable
    {
        private bool _hasSideCar;
        
        public Motorcycle(string brandName, float currentSpeed, float fuel, bool hasSideCar) : base(brandName, currentSpeed, fuel)
        {
            _hasSideCar = hasSideCar;
        }

        public void PerformWheelie()
        {
            Console.WriteLine("Wheelie ... .");
        }

        public void SteerLeft()
        {
            Console.WriteLine("Motorcycle is steering left.");
        }

        public void SteerRight()
        {
            if(_hasSideCar)
                Console.WriteLine("Motorcycle is steering right.");
            else
                Console.WriteLine("Motor doesn't have side car.");
        }
    }
}