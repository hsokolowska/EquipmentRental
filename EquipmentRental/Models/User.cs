namespace EquipmentRental.Models;

public abstract class User
{
    public string UserId { get; set; }
    public string UserName { get; set; }
    public string UserSurname { get; set; }
    private static int _userIdCounter = 0;

    protected User(string userName, string userSurname)
    {
        UserId = (++_userIdCounter).ToString();
        UserName = userName;
        UserSurname = userSurname;
    }
    public abstract int GetMaxReservations();
}