def zarzadzanie_zadaniami():
    print("Zarzadzanie Zadaniami")
    lista_zadan = []

    while True:
        print("\nManu:")
        print("1. Wyświetl zadań")
        print("2.Dodaj zadań")
        print("3.usun zadań")
        print("4.zakonczenie pracy")

        wybor = input("Wybierz opcje: ")

        if wybor == '1':
            if lista_zadan:
                print("\nTwoje zadania:")