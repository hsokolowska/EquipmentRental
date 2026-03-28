namespace EquipmentRental.Exceptions;

public class RentalConflictException(int id) : Exception($"Equipment{id} is already reserved for the period:");