class SilverMoblin : Moblin
{
    public SilverMoblin()
    {
        Name = "Silver Moblin";
        Health = 1440;
        Damage = 72;
        Defense = 720;
        Color = "Silver";
        UpdateFrom = "Black Moblin";
        UpdateTo = null;
        Console.WriteLine("Name is : " + Name + ", health: " + Health + ", attack power: " + Damage + ", shield: " + Defense + ", color: " + Color + ", updated from: " + UpdateFrom + ", update to: " + UpdateTo);
    }
}