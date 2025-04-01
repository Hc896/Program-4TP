import random

def gra_zgadywanie_liczby():
    print("Witaj w grze! Zgadnij liczbę między 1 a 100.")
    
    # Losujemy liczbę, którą użytkownik ma zgadnąć
    liczba_do_zgadnięcia = random.randint(1, 100)
    
    # Ustawiamy początkową liczbę prób
    próby = 0
    
    while True:
        próby += 1
        # Prosimy użytkownika o podanie liczby
        próba = int(input("Podaj swoją liczbę: "))
        
        if próba < liczba_do_zgadnięcia:
            print("Za mało! Spróbuj ponownie.")
        elif próba > liczba_do_zgadnięcia:
            print("Za dużo! Spróbuj ponownie.")
        else:
            print(f"Brawo! Zgadłeś liczbę {liczba_do_zgadnięcia} w {próby} próbach.")
            break

# Uruchamiamy grę
gra_zgadywanie_liczby()
