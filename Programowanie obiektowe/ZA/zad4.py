tekst = input("Wprowadź łańcuch tekstowy: ")
litera = input("Podaj literę do zliczenia: ")

if len(litera) != 1:
    print("Proszę podać tylko jedną literę.")
else:
    wystapienia = tekst.count(litera)

    print(f"Litera '{litera}' występuje {wystapienia} razy w podanym łańcuchu.")
