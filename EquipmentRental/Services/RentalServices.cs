using EquipmentRental.Exceptions;
using EquipmentRental.Models;
namespace EquipmentRental.Services;

public class RentalServices : IRentalServices
{
    private readonly List<Rental> _rentals = [];

    public void CreateRental(User user, Equipment equipment, DateTime from, DateTime to)
    {
        if (!equipment.IsAvailable)
        {
            throw new EquipmentNotAvailableException(equipment.Id);
        }
        
        int activeUserRentals = _rentals.Count(rental => 
            !rental.IsCancelled && rental.User == user);

        if (activeUserRentals>= user.GetMaxReservations())
        {
            throw new AlreadyMaximumRentalsException(user.UserId);
        }
        
        bool rentalConflict = _rentals.Any(rental =>
            !rental.IsCancelled  && rental.Equipment == equipment && rental.Overlaps(from, to));

        if (rentalConflict)
        {
            throw new RentalConflictException(equipment.Id);

        }
        
        var newRental = new Rental(user,equipment, from, to);
        
        _rentals.Add(newRental);
    }
    
    public void CancelRental(int rentalId)
    {
        var rental = _rentals.FirstOrDefault(rental => rental.Id == rentalId);
        
        if (rental is null)
        {
            throw new RentalNotFoundException(rental.Id);
        }
        
        rental.Cancel();
    }
    
    public List<Rental> GetUserRentals(User user)
    {
        return _rentals.Where(rental => rental.User == user && !rental.IsCancelled).ToList();
    }
    
    public List<Rental> GetAll()
    {
        return _rentals;
    }
}