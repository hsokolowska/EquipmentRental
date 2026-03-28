namespace EquipmentRental.Exceptions;

public class EquipmentNotAvailableException(string equipmentId) : Exception($"Equipment with id {equipmentId} is not available.");