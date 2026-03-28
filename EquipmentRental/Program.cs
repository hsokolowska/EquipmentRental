using EquipmentRental.Models;
using EquipmentRental.Services;


Projector p1 = new Projector("Epson", 5000, true);
Laptop l1 = new Laptop("HP","i9",5);
Camera c1 = new Camera("Canon", 1000, 3);
Employee e1 = new Employee("Jan", "Kowalski");
Student s1 = new Student("Anna", "Nowak");

Console.WriteLine(p1.Id);
Console.WriteLine(l1.Id);
Console.WriteLine(c1.Id);
Console.WriteLine(p1.IsAvailable);