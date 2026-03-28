namespace EquipmentRental.Models;

public class Employee : User
{
    public override int GetMaxReservations() => 5;
    
    public Employee(string userName, string userSurname) : base(userName, userSurname)
    {
        
    }
}