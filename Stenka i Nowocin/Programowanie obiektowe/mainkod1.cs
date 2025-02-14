
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    
    
    Person persol = new Person();
    
    
    Console.WriteLine(persol.name);//wysleiwtla imie z classy person
    Console.WriteLine(persol.age);//wysleiwtla age z classy person
    persol.name = "Paweł";//nadpisuejmy name z classy person 
    Console.WriteLine(persol.name);//wysietlamy nadpsiany name 
    persol.age = 18;//nadpisujemy age 
    Console.WriteLine(persol.age);//wysietlamy nadpsiany age
    persol.SayHello();// wywoluje metode sayhello na obiekcie persol
    
    //twoerzenie kolejn instacji klasy z jednym parametrem 
    // aby prawidlowo wywolac konstruktor musze dostaczyc wartosc parametru
    //ponizej wysylam jako Wiktor
    //parametry sluza do ustwanienia wrtosci startowych dla pol klasy w momencie tworzxenia obiektu
    Person person2 = new Person("Wiktor");
    Console.WriteLine(person2.name);
    
    Person person3 = new Person("Bartek",15);
    Console.WriteLine(person3.name);
    Console.WriteLine(person3.age);
    
    Person person4 = new Person(person3);
    Console.WriteLine("skopiowane imie od person3 " + person4.name);
    
    }
  
  //klasa jest szablonem -przepisem na obiekt. Definiujemy wewnatrz niej atrybuty/
  //wlasiciwosci reperezentujące stron obiekt oraz metody - zachowanie obiektu
  class Person {
      public string name = "brak";//name i age to pole klasy kazdy obiekt ma swoje 
      public int age = 0;
      static int licznik;//pole statyczne wspolne dla kazdego obiektu
      
      public Person(){
          Console.WriteLine("jestem konsturkoter");
      }
      
      public Person(string imieZkonstruktora){
          name = imieZkonstruktora;
          Console.WriteLine("ustawilem "+name+" konsturkoterm");
      }
      
      //ponizej definujemy konstruktor z dwoma parametrami nazwy parametrow to 
      //place holdery czyli sa dowolne ale wewnatz konstruktoa muszą byc zgodne 
      //name - name3 oznacza ze pola klasy zapisuje wartosc przy wywolaniu konstruktora
      // slowo thios oznacza odsniesie/wskazanie do biezonczego obniektu this.name
      public Person(string name,int age){
          Console.WriteLine("dziala konstruktor z dwoma parametrami");
          this.name = name;
          this.age = age;
           
      }
      
      
      public Person(Person existingPerson){
          Console.WriteLine("dziala konstruiktor kopiujący");
          this.name = existingPerson.name;
      }
      
      
public void SayHello(){//co nazley zrobic zeby wywoalc to wenotaz klasy
          Console.WriteLine("Hello" + name );
              
      }

  }

}
