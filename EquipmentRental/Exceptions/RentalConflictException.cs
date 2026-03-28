namespace EquipmentRental.Exceptions;

public class RentalConflictException(string id) : Exception($"Equipment{id} is already reserved for the period:");