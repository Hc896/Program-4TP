def licznik_slow():
    # Pobieramy tekst od użytkownika
    tekst = input("Wpisz tekst: ")
    
    # Rozdzielamy tekst na słowa i liczymy ich ilość
    lista_slow = tekst.split()
    liczba_slow = len(lista_slow)
    
    # Wyświetlamy wynik
    print(f"Liczba słów w tekście: {liczba_slow}")

# Uruchamiamy licznik słów
licznik_slow()
