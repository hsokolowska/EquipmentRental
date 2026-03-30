# EquipmentRental
Projekt przedstawia prosty system do zarządzania wypozyczaniem sprzetu na uczelni
Umozliwia: dodawanie uzytkownikow, sprzetu, sprawdzanie dostepnosci, kontrole limitow oraz zwrot wypozyczen
System został napisany w C# z wykorzystaniem podejścia obiektowego.

## Struktura
System został podzielony na kilka glownych elementow:
Models (dane) - czyli wszystkie nawazniejsze klasy zarzadzajace podstawowa logika
Services (logika biznesowa) - cala obsluga wyporzyczen i zarzadzaniem sprzetem
Exceptions (bledy) - obsluga bledow
Enums - typy wyliczalne
Taki podzial zapewnie przejrzystkosc projektu i umozliwia dalszy rozwoj projektu

### Decyzje projektowe
Kazda klasa ma jedna odpowiedzialnosc (Single Responsibility Principle)
Logika biznesowa nie jest rozproszona miedzy klasami tylko w specjalnie stworzonych klasach
Klasy komunikuja sie przez interfejsy i modele danych

### Uruchomienie w JetBrain Rider
1. Pobierz ZIP
2. Rozpakuj i otworz plik EquipmentRental.csproj w Rider
