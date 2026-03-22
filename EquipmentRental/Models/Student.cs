namespace EquipmentRental.Models;

public class Student : User
{
    public override int GetMaxReservations() => 2;

    public Student(string userName, string userSurname) : base(userName, userSurname)
    {
        
    }
}