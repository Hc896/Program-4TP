using System;
//dziedziczeine interherencaj
class HelloWorld {
    static void Main() {
        Console.WriteLine("Hello World");

        // Tworzenie obiektu klasy Car
        Car myCar = new Car();
        myCar.licensePlate ="GPU sij34";
        Console.WriteLine(myCar.licensePlate);
        myCar.start();
        myCar.refuel();
    }

    // W przyszłości będzie to klasa abstrakcyjna
    public class Vehicle { // Klasa bazowa, typ nadrzędny 
        public string licensePlate;

        public void start() {//metoda dl; a obiektow typu vehicle i wszsykie dziedziczancych
            Console.WriteLine("vehicle started");
        }
    }
/*przyklad klasy dziedizcznej car jest dzieckiem vehicle.
wnioosek logiczny kazdy somochod jest pojazdem a nie kazdy pojazd jest samochodem 
dlatego mamy jednokirunkowy przeplyw danych rodzicow dziecka pojazd nie posiada metody refuel */
    public class Car : Vehicle {
        public void refuel() {//to metoda moja wszyustkie samovhody
            Console.WriteLine("car refueled");
        }
    }
}
