using System;

class HelloWorld {
    static void Main() {
        Samochod samochod1 = new Samochod("auto", "bmw", 36);
        Console.WriteLine(samochod1.nazwa);
        Console.WriteLine(samochod1.marka);
        Console.WriteLine(samochod1.iloscPaliwa);
        samochod1.jedz();
        samochod1.zatankuj(10);
    }
}

class Samochod {
    public string nazwa;
    public string marka;
    public int iloscPaliwa;
   
    public Samochod(string nazwa, string marka, int iloscPaliwa) {
        this.nazwa = nazwa;
        this.marka = marka;
        this.iloscPaliwa = iloscPaliwa;
    }
     public void jedz(){
            if(iloscPaliwa > 0){
                Console.WriteLine("ruszam");
            }else{
                Console.WriteLine("zbiornik pusty, nie jadę");
            }
        }
        public void zatankuj(int paliwo){
            iloscPaliwa = iloscPaliwa + paliwo;
            Console.WriteLine("samochód zatankowany o " + paliwo + ", aktualny stan zbiornika to: " + iloscPaliwa);
        }
    
    
}