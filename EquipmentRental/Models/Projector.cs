namespace EquipmentRental.Models;

public class Projector : Equipment
{
    public int Lumens { get; set; }
    public Boolean IsPortable { get; set; }
    
    public Projector(string name, int lumens, Boolean isPortable) : base(name)
    {
        Lumens = lumens;
        IsPortable = isPortable;
    }
}