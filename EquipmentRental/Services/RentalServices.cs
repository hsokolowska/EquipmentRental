using EquipmentRental.Models;
namespace EquipmentRental.Services;

public class RentalServices : IRentalServices
{
    private readonly List<Rental> _rentals = [];

    public void CreateRental(User user, Equipment equipment, DateTime from, DateTime to)
    {
        if (!equipment.IsAvailable)
        {
            Console.WriteLine("Not available, będzie excepytion");
        }
        
        int activeUserRentals = _rentals.Count(rental => 
            !rental.IsCancelled && rental.User == user);

        if (activeUserRentals>= user.GetMaxReservations())
        {
            Console.WriteLine("Already maximum reservations, będzie excepytion");
        }
        
        bool rentalConflict = _rentals.Any(rental =>
            !rental.IsCancelled  && rental.Equipment == equipment && rental.Overlaps(from, to));

        if (rentalConflict)
        {
            Console.WriteLine("Conflict, będzie excepytion");
        }
        
        var newRental = new Rental(user,equipment, from, to);
        
        _rentals.Add(newRental);
    }
    
    public void CancelRental(int rentalId)
    {
        var rental = _rentals.FirstOrDefault(rental => rental.Id == rentalId);
        
        if (rental is null)
        {
            Console.WriteLine("Nie mozna usunąć wypożyczenia, bedzie exception");
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