using System;

namespace Race
{
    public class Car: Vehicle, IDriveable
    {
        private int _doorCount;
        
        public Car(string brandName, float currentSpeed, float fuel, int doorCount) : base(brandName, currentSpeed, fuel)
        {
            _doorCount = doorCount;
        }

        public void Honking()
        {
            Console.WriteLine("Honking ... .");
        }

        public void SteerLeft()
        {
            Console.WriteLine("Car is steering left.");
        }

        public void SteerRight()
        {
            Console.WriteLine("Car is steering right.");
        }
    }
}