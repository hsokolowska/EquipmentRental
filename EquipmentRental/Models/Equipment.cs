using EquipmentRental.Enums;

namespace EquipmentRental.Models;

public abstract class Equipment
{
    public int Id { get; private set; }
    public EquipmentStatus Status { get; set; }
    public string Name { get; set; }
    public bool IsAvailable { get; set; } = true;
    private static int _counter = 0;
    
    protected Equipment(string name) 
    {
        Id = (++_counter);
        Name = name;
    }

    
}