//Funkcje to reużywalne bloki kodu zaprojektowane do wykonania jakiegoś konkretnego zadania.
//Kod funkcji zostaje wykonany w momencie gdy "coś" ją wywoła. Function is executed when something
//invoke it.

//Reużywalność - wykorzystanie tej samej funkcji z innymi wartościami parametrów dla różnych obiektów

//Metoda = funkcja, metoda to funkcja zdefiniowana wewnątrz klasy.

//składnia funkcji / metody: 
//modyfikator dostępu, typ zwracany albo void jeśli nic nie zwraca, nazwa metody,
//w nawiasie parametry i ich typy, wciele funkcji pamiętamy o słowie return jeśli 
//metoda ma coś zwrócić

//1.
public void SayHello(){ 
          Console.WriteLine("Hello "+ name+"!");
      }
//Powyższa metoda nic nie zwraca (void) i nie przyjmuje żadnych parametrów bo jest pusty nawias
//Jedyne jej zadanie to wykonanie instrukcji z jej wnętrza - Console.WriteLine
//Aby jej użyć potrzebujemy obiektu - instancji klasy do której należy

//Wywołanie: obiekt.SayHello();

//2.
public static void SayHello2(){ 
          Console.WriteLine("Hello "+ name+"!");
      }

//Jak wyżej, tylko nie trzeba obiektu do wywołania bo mamy słowo kluczowe static.

//Wywołanie: sayHello2();

//3.
public string SayHello3(){ 
          return "Hello "+ name+"!";
      }

//ta meteoda zwraca typ string, nie przyjmuje żadnych parametrów - musimy pamiętać w ciele metody 
//o słowie kluczowym return

//Wywołanie: obiekt.SayHello3();

//4.
public string getName(){
          return _name;
      }

//ta meteoda zwraca typ string, nie przyjmuje żadnych parametrów. Getter jest read only -
//wywołanie zwróci wartość zmiennej prywatnej _name

//Wywołanie: obiekt.getName();

5.
public void setName(string name){
          _name = name;
          }
// ta metoda (setter) nic nie zwraca ale przyjmuje jeden parametr typu string
//Ustawia zmienną z pola klasy _name na wartość przysłaną w parametrze.

//Wywołanie: obiekt.setName("Kazik");
//Poniżej przykładowy konstruktor - metoda specjalna w składni nie podajemy typu zwracanego.
//Nazwa musi być taka sama jak nazwa klasy. Konstruktor tworzy obiekt - instancje klasy do której
//należy. 

public Person(string name, int age) {
          Console.WriteLine("działa konstruktor z dwoma parametrami");
          this.name = name;
          this.age = age;
      }
//ten konstruktor przyjmuje dwa parametry: typu string dla imienia oraz typu int dla wieku.
//Wartość tych pól klasy(name i age) jest ustwiona wartościami przekazanymi do konstruktora
//w momencie jego wywołania.

//Wywołanie: Pracownik pracownik1 = new Pracownik("Wiktor", 18);

//public void Jedz() - metoda bez argumentowa - wystiwetlajaca komunikat jedziemy albo nie.
//sprawdzamy stan zbiornika w instrukcji warunkowej.

//public string Jedz2() - wenątrz funkcji musimy zwrócić komunikat w formie string czyli np return "jedziemy"



//public void Zatankuj(int ilośćPaliwaDoZatankowania){ funkcja przyjmuje jeden parametr -
//zwiekszała zawartosc zbiornika paliwa czyli iloscPaliwa += ilośćPaliwaDoZatankowania


public string LvlUp(int str, int hp){
strength = strength + str;
hitPoints = hitPoints + hp;
return "gratulacje.....";}
//Ta metoda zwraca typ string i przyjmuje dwa argumenty typu int. Zwiększa wartości pól klasy o
//wartości przekazane w argumentach w momencie jej wywołania.

//Wywołanie: obiekt.lvlUp(5, 10);