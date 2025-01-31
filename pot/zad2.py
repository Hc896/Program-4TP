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
        