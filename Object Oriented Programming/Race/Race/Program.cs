namespace Race
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var benz = new Car("Benz", 120, 64.5f, 4);
            benz.IncreaseSpeed(10.5f);
            benz.DecreaseSpeed(3.75f);
            benz.Refuel(25f);
            benz.Honking();
            benz.SteerLeft();
            
            var honda = new Motorcycle("Honda", 93.219f, 29.64f, false);
            honda.PerformWheelie();
            honda.SteerRight();
        }
    }
}