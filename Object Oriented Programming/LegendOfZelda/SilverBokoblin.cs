class SilverBokoblin : Bokoblin
{
    public SilverBokoblin()
    {
        Name = "Silver Bokoblin";
        Health = 720;
        Damage = 36;
        Defense = 360;
        Color = "Silver";
        UpdateFrom = "Black Bokoblin";
        UpdateTo = "Golden Bokoblin";
        Console.WriteLine("Name is : " + Name + " health : " + Health + " the attack power is : " + Damage + " has a shield of : " + Defense + " the color is : " + Color + " was updated from : " + UpdateFrom + " is goint to Update to : " + UpdateTo);
    }
    public override void Attack()
    {

    }
}