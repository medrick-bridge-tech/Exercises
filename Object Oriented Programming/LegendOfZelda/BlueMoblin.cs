class BlueMoblin : Moblin
{
    public BlueMoblin()
    {
        Name = "Blue Moblin";
        Health = 240;
        Damage = 20;
        Defense = 12;
        Color = "Blue";
        UpdateFrom = "Bokoblin";
        UpdateTo = "Black Moblin";
        Console.WriteLine("Name is : " + Name + " health : " + Health + " the attack power is : " + Damage + " has a shield of : " + Defense + " the color is : " + Color + " was updated from : " + UpdateFrom + " is goint to Update to : " + UpdateTo);
    }
}