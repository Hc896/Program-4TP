using System;
 
class HelloWorld {
    static void Main() {
        // Wyświetla "Hello World" na konsoli
        Console.WriteLine("Hello World");
        // Tworzenie obiektu klasy Car
        Vehicle vehicle = new Vehicle();
        vehicle.licensePlate = "GDT5356";
        Console.WriteLine(vehicle.licensePlate);
        vehicle.start();
 
 
        // Tworzenie obiektu klasy Car
        Car car = new Car();
        car.licensePlate = "FFS2825";
        Console.WriteLine(car.licensePlate);
        car.start();
        car.refuel();
    }
 
    // Definicja klasy Vehicle (pojazd)
    public class Vehicle { // klasa bazowa, typ nadrzędny
 
        // Pole przechowujące numer rejestracyjny pojazdu
        public string licensePlate;
 
        // Metoda uruchamiająca pojazd
        public void start() {
            Console.WriteLine("Vehicle started");
        }
    }
 
    // Definicja klasy Car, która dziedziczy po klasie Vehicle
    public class Car : Vehicle {
        // Metoda specyficzna dla klasy Car
        public void refuel() {
            Console.WriteLine("Car refuel");
        }
    }
}