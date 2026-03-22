using EquipmentRental.Models;
namespace EquipmentRental.Services;

public interface IRentalServices
{
    public void CreateRental(User user, Equipment equipment, DateTime from, DateTime to);
    public void CancelRental(int reservationId);
    public List<Rental> GetUserRentals(User user);
    public List<Rental> GetAll();
}