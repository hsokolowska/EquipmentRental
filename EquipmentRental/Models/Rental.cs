namespace EquipmentRental.Models;

public class Rental
{
    private static int _nextId = 0;
    public int Id { get; private set; }
    public User User { get; private set; }
    public Equipment Equipment { get; private set; }
    public DateTime From { get; private set; }
    public DateTime To { get; private set; }
    public bool IsCancelled { get; private set; }
    
    public Rental(User user, Equipment equipment, DateTime from, DateTime to)
    {
        Id = (++_nextId);
        User = user;
        Equipment = equipment;
        From = from;
        To = to;
        IsCancelled = false;
    }
    
    public void Cancel()
    {
        IsCancelled = true;
    }
    
    public bool Overlaps(DateTime from, DateTime to)
    {
        return !(From > to || from > To);
    }
}