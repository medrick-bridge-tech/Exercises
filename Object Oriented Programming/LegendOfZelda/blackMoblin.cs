class BlackMoblin : Moblin
{
    public BlackMoblin()
    {
        Name = "Black Moblin";
        Health = 720;
        Damage = 36;
        Defense = 360;
        Color = "Black";
        UpdateFrom = "Blue Moblin";
        UpdateTo = "Silver Moblin";
        Console.WriteLine("Name is : " + Name + " health : " + Health + " the attack power is : " + Damage + " has a shield of : " + Defense + " the color is : " + Color + " was updated from : " + UpdateFrom + " is goint to Update to : " + UpdateTo);
    }
}