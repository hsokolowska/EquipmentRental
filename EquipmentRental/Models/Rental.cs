namespace EquipmentRental.Models;

public class Rental
{
    public string Id { get; private set; }
    public User User { get; private set; }
    public Equipment Equipment { get; private set; }
    private static int _rentalCounter = 0;
    
    public Rental(User user, Equipment equipment, int howManyDays)
    {
        Id = (++_rentalCounter).ToString();
        User = user;
        Equipment = equipment;
    }
}