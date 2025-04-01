def kalkulator_dzialan_matematycznych():
    print("Witaj w kalkulatorze działań matematycznych!")
    print("Dostępne operacje:")
    print("1. Dodawanie")
    print("2. Odejmowanie")
    print("3. Mnożenie")
    print("4. Dzielenie")
    
    # Pobieramy wybór operacji od użytkownika
    wybor = input("Wybierz operację (1/2/3/4): ")
    
    # Pobieramy dwie liczby od użytkownika
    try:
        liczba1 = float(input("Podaj pierwszą liczbę: "))
        liczba2 = float(input("Podaj drugą liczbę: "))
        
        if wybor == '1':
            wynik = liczba1 + liczba2
            print(f"Wynik dodawania: {wynik}")
        elif wybor == '2':
            wynik = liczba1 - liczba2
            print(f"Wynik odejmowania: {wynik}")
        elif wybor == '3':
            wynik = liczba1 * liczba2
            print(f"Wynik mnożenia: {wynik}")
        elif wybor == '4':
            if liczba2 != 0:
                wynik = liczba1 / liczba2
                print(f"Wynik dzielenia: {wynik}")
            else:
                print("Błąd! Nie można dzielić przez zero.")
        else:
            print("Nieprawidłowy wybór! Wybierz 1, 2, 3 lub 4.")
    except ValueError:
        print("Błąd! Proszę podać poprawne liczby.")
        
# Uruchamiamy kalkulator
kalkulator_dzialan_matematycznych()
