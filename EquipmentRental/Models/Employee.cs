namespace EquipmentRental.Models;

public class Employee : User
{
    private static int _employeetMaxRents = 5;
    public Employee(string userName, string userSurname) : base(userName, userSurname)
    {
        _employeetMaxRents = _employeetMaxRents;
    }
}