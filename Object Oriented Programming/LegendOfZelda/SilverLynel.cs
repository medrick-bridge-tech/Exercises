class SilverLynel : Lynel
{
    public SilverLynel()
    {
        Name = "Silver Lynel";
        Health = 4000;
        Damage = 72;
        Defense = 600;
        Color = null;
        Type = null;
        Console.WriteLine("Name is : " + Name + ", health: " + Health + ", attack power: " + Damage + ", shield: " + Defense);
    }
}