namespace Race
{
    public class Vehicle
    {
        private string _brandName;
        private float _currentSpeed;
        private float _currentFuel;

        public string BrandName => _brandName;
        public float CurrentSpeed => _currentSpeed;
        public float CurrentFuel => _currentFuel;

        public Vehicle(string brandName, float currentSpeed, float fuel)
        {
            _brandName = brandName;
            _currentSpeed = currentSpeed;
            _currentFuel = fuel;
        }

        public void IncreaseSpeed(float velocity)
        {
            _currentSpeed += velocity;
        }

        public void DecreaseSpeed(float velocity)
        {
            _currentSpeed -= velocity;
        }

        public void Refuel(float liter)
        {
            _currentFuel += liter;
        }
    }
}