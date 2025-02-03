class Ksiazka:
    def __init__(self, __tytul, __autor, __rok_wydania):
        self.__tytul = __tytul
        self.__autor = __autor
        self.__rok_wydania = __rok_wydania

    def __str__(self):
        return f"{self.__tytul} {self.__autor} {self.__rok_wydania}"
    
class Biblioteka:
    def __init__(self):
        self.ksiazki = []

    def dodaj_ksiazke(self, Ksiazka):
        self.ksiazki.append(Ksiazka)
    
    def usun_ksiazke(self, tutyl):
        self.ksiazki = [Ksiazka for Ksiazka in self.ksiazki if Ksiazka.tytul != tutyl]
    
    def wyswietl_ksiazke(self):
        for ksiazka in self.ksiazki:
            print(ksiazka)
    
    def wyczytaj_z_pliku(self, nazwa_pliku="bib.txt"):
        with open(nazwa_pliku) as plik:
            dane = plik.read()
            print(dane)
    
biblioteka = Biblioteka()
ksiazka1 = Ksiazka("Wiedźmin", "Andrzej Sapkowski", 1993)
ksiazka2 = Ksiazka("Dziady", "Adam Mickiewicz", 1823)

biblioteka.dodaj_ksiazke(ksiazka1)
biblioteka.dodaj_ksiazke(ksiazka2)
biblioteka.wyswietl_ksiazke()

biblioteka.usun_ksiazke("Wiedźmin")
biblioteka.wyswietl_ksiazke()

biblioteka.wyczytaj_z_pliku()