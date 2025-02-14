class Urzadzenie:
    
    def wyswietl_komunikat(self):
        print("Komunikat z urządzenia.")

class Pralka(Urzadzenie):
    def __init__(self):
        self.__numer_programu = 0
    
    def ustaw_program(self, numer):
        if 1 <= numer <= 12:
            self.__numer_programu = numer
        else:
             self.__numer_programu = 0

    def wyswietl_program(self):
        print(f"Numer programu prania: {self.__numer_programu}")

class Odkurzacz(Urzadzenie):
    def __init__(self):
        self.__wlaczony = False
    
    def wlacz(self):
        self.__wlaczony = True
        print("Odkurzacz włączony")

    def wylacz(self):
        self.__wlaczony = False
    
    def wyladowanie(self, razy):
        if razy in (1, 3):
            for _ in range (razy):
                print("Odkurzacz wylądował się")

pralka = Pralka()
pralka.ustaw_program(5)
pralka.wyswietl_program()
pralka.ustaw_program(20)
pralka.wyswietl_program