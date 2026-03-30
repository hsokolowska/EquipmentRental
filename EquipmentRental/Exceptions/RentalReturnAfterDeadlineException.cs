namespace EquipmentRental.Exceptions;

public class RentalReturnAfterDeadlineException(int id) : Exception($"Rental with id {id} is returned after deadline.");
