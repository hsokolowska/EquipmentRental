namespace EquipmentRental.Models;

public abstract class Equipment
{
    public string Id { get; private set; }
    public string Name { get; set; }
    public bool IsAvailable { get; set; } = true;
    private static int _counter = 0;
    
    protected Equipment(string name) 
    {
        Id = (++_counter).ToString();
        Name = name;
    }

    
}