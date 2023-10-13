class Enemy
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string Rewards { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }
    public int Defense { get; set; }
    public void Move()
    {
        
    }
    public virtual void Attack()
    {
        
    }
    public void TakeDamage(int damage)
    {
       
    }
}