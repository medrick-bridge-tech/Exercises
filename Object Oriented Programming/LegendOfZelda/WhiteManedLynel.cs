class WhiteManedLynel : Lynel
{
    public WhiteManedLynel()
    {
        Name = "White-Maned Lynel";
        Health = 3000;
        Damage = 62;
        Defense = 200;
        Color = null;
        Type = null;
        Console.WriteLine("Name is : " + Name + ", health: " + Health + ", attack power: " + Damage + ", shield: " + Defense);
    }
}