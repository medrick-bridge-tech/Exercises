class BlueManedLynel : Lynel
{
    public BlueManedLynel()
    {
        Name = "Blue-Maned Lynel";
        Health = 2000;
        Damage = 50;
        Defense = 150;
        Color = null;
        Type = null;
        Console.WriteLine("Name is : " + Name + ", health: " + Health + ", attack power: " + Damage + ", shield: " + Defense);
    }
}