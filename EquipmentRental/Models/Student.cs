namespace EquipmentRental.Models;

public class Student : User
{
    private static int _studentMaxRents = 2;

    public Student(string userName, string userSurname) : base(userName, userSurname)
    {
        _studentMaxRents = _studentMaxRents;
    }
}