namespace EquipmentRental.Models;

public class Laptop : Equipment
{
    public string Processor { get; set; }
    public int RamGB { get; set; }
    
    public Laptop(string name, string processor, int ram) : base(name)
    {
        Processor = processor;
        RamGB = ram;
    }
    
}