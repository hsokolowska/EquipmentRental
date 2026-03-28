namespace EquipmentRental.Exceptions;

public class AlreadyMaximumRentalsException(string userId) : Exception($"User {userId} already has maximum rentals!");