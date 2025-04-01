import random

def wyswietl_tabliczke(rozmiar=10):
    """Wyświetla tabliczkę mnożenia do podanego rozmiaru."""
    for i in range(1, rozmiar + 1):
        for j in range(1, rozmiar + 1):
            print(f"{i*j:4}", end=" ")
        print()

def generuj_przykłady(liczba_przykładów=5, zakres=10):
    """Generuje losowe przykłady do ćwiczenia tabliczki mnożenia."""
    for _ in range(liczba_przykładów):
        a, b = random.randint(1, zakres), random.randint(1, zakres)
        odpowiedz = int(input(f"Ile to {a} × {b}? "))
        if odpowiedz == a * b:
            print("✅ Poprawna odpowiedź!")
        else:
            print(f"❌ Błąd! Poprawna odpowiedź to {a * b}.")

# Przykłady użycia:
print("Tabliczka mnożenia:")
wyswietl_tabliczke()
print("\nĆwiczenia:")
generuj_przykłady()
