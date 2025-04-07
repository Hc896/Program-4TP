class KontoBankowe:
    def __init__(self, wlasciciel, saldo):
        self.wlasciciel = wlasciciel
        self.__saldo = saldo

    def pokaz_saldo(self):
        return self.__saldo

    def wplata(self, kwota):
        if kwota > 0:
            self.__saldo += kwota

    def wyplata(self, kwota):
        if kwota > 0 and kwota <= self.__saldo:
            self.__saldo -= kwota
            return True
        else:
            return False


class KontoPremium(KontoBankowe):
    def wplata(self, kwota):
        bonus = kwota * 0.02
        super().wplata(kwota + bonus)


konto1 = KontoBankowe("Anna", 1000)
konto1.wplata(500)
konto1.wyplata(200)
print(konto1.pokaz_saldo())

konto2 = KontoPremium("Jan", 2000)
konto2.wplata(1000)
print(konto2.pokaz_saldo())

konta = []
konta.append(konto1)
konta.append(konto2)

for konto in konta:
    print(f"Właściciel: {konto.wlasciciel}")

def menu(konto):
    while True:
        print("\n1. Pokaż saldo\n2. Wpłata\n3. Wypłata\n4. Wyjście")
        wybor = input("Wybierz opcję: ")
        if wybor == "1":
            print("Saldo:", konto.pokaz_saldo())
        elif wybor == "2":
            kwota = float(input("Kwota wpłaty: "))
            konto.wplata(kwota)
        elif wybor == "3":
            kwota = float(input("Kwota wypłaty: "))
            if not konto.wyplata(kwota):
                print("Brak wystarczających środków.")
        elif wybor == "4":
            break
        else:
            print("Nieznana opcja.")

konto_testowe = KontoBankowe("Anna", 500)
menu(konto_testowe)
