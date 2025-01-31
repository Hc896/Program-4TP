import random

class TablicaLiczb:
    def __init__(self, rozmiar):
        self.__rozmiar = rozmiar
        self.__tablica = [random.randint(1,1000) for _ in range (rozmiar)]
    
    def wyswietl(self):
        for i, wartosc in enumerate(self.__tablica):
            print(f"{i}: {wartosc}")
        
    def znajdz_wartosc(self, szukana):
        try:
            return self.__tablica.index(szukana)
        except ValueError:
            return -1
        
tablica = TablicaLiczb(10)
tablica.wyswietl()
