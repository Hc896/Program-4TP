import random

def symulator_biletu_matematystycznego():
    # Określamy zakres liczb i liczbę losowanych
    zakres = 49
    liczba_liczb = 6

    # Generujemy losowy zestaw liczb
    wylosowane_liczby = random.sample(range(1, zakres + 1), liczba_liczb)

    # Sortujemy liczby rosnąco (opcjonalne)
    wylosowane_liczby.sort()

    print(f"Wylosowane liczby: {wylosowane_liczby}")

# Uruchamiamy symulator
symulator_biletu_matematystycznego()
