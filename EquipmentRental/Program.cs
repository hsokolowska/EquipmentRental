using EquipmentRental.Models;
using EquipmentRental.Services;


Projector p1 = new Projector("Epson", 5000, true);
Laptop l1 = new Laptop("HP","i9",5);
Camera c1 = new Camera("Canon", 1000, 3);
Employee e1 = new Employee("Jan", "Kowalski");
Student s1 = new Student("Anna", "Nowak");

IEquipmentService equipmentService = new EquipmentService();

equipmentService.AddEquipment(p1);
equipmentService.AddEquipment(l1);
equipmentService.AddEquipment(c1);
p1.IsAvailable = false;

IRentalServices rentalServices = new RentalServices();

//proper rental
rentalServices.CreateRental(s1,l1,new DateTime(2026,03,30),new  DateTime(2036,04,5));
rentalServices.CreateRental(e1,c1,new DateTime(2026,03,20),new  DateTime(2026,03,22));


try
{
    Console.WriteLine("\n[Attempt to rent an equipment that is not available]: ");
    rentalServices.CreateRental(s1,p1,new DateTime(2026,03,30),new  DateTime(2026,04,5));
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    Console.WriteLine("\n[Attempt to return an equipment in time]: ");
    rentalServices.CancelRental(1);
    Console.WriteLine("Return successfully!");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    Console.WriteLine("\n[Attempt to return after the deadline]: ");
    rentalServices.CancelRental(2);
    Console.WriteLine("Return successfully!");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
Console.WriteLine("\n[System state]: ");

foreach (var equipment in equipmentService.GetAll())
{
    Console.WriteLine(equipment);
}
