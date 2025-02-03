class Ksiazka:
    def __init__(self, tytul, autor, rok_wydania):
        self.tytul = tytul
        self.autor = autor
        self.rok_wydania = rok_wydania

    def __str__(self):
        return f"'{self.tytul}' - {self.autor} ({self.rok_wydania})"

class Biblioteka:
    def __init__(self):
        self.__ksiazki = []  # Initialize book list correctly

    def dodaj_ksiazke(self, ksiazka):
        self.__ksiazki.append(ksiazka)

    def usun_ksiazke(self, tytul):
        for ksiazka in self.__ksiazki:
            if ksiazka.tytul == tytul:
                self.__ksiazki.remove(ksiazka)
                print(f"Książka '{tytul}' została usunięta.")
                return
        print(f"Książka '{tytul}' nie została znaleziona.")

    def wyswietl_ksiazki(self):  # Fixed name from wyswietl_ksiazke
        if not self.__ksiazki:
            print("Biblioteka jest pusta.")
        else:
            for ksiazka in self.__ksiazki:
                print(ksiazka)

    def wyczytaj_z_pliku(self, nazwa_pliku="bib.txt"):
        try:
            with open(nazwa_pliku, "r", encoding="utf-8") as plik:
                for linia in plik:
                    dane = linia.strip().split(";")
                    if len(dane) == 3:
                        tytul, autor, rok_wydania = dane
                        self.dodaj_ksiazke(Ksiazka(tytul, autor, int(rok_wydania)))
            print(f"Książki wczytane z pliku '{nazwa_pliku}'.")
        except FileNotFoundError:
            print(f"Plik '{nazwa_pliku}' nie istnieje. Tworzenie pustego pliku...")
            open(nazwa_pliku, "w", encoding="utf-8").close()

# Tworzenie biblioteki
biblioteka = Biblioteka()

# Dodawanie książek
ksiazka1 = Ksiazka("Wiedźmin", "Andrzej Sapkowski", 1993)
ksiazka2 = Ksiazka("Dziady", "Adam Mickiewicz", 1823)

biblioteka.dodaj_ksiazke(ksiazka1)
biblioteka.dodaj_ksiazke(ksiazka2)

# Wyświetlenie książek
biblioteka.wyswietl_ksiazki()

# Usunięcie książki
biblioteka.usun_ksiazke("Wiedźmin")
biblioteka.wyswietl_ksiazki()

# Wczytywanie z pliku
biblioteka.wyczytaj_z_pliku()
