from datetime import datetime

def kalkulator_wieku():
    # Pobieramy datę urodzenia od użytkownika
    data_urodzenia_str = input("Podaj datę urodzenia w formacie RRRR-MM-DD: ")
    
    # Konwertujemy ją na obiekt typu datetime
    data_urodzenia = datetime.strptime(data_urodzenia_str, "%Y-%m-%d")
    
    # Pobieramy bieżącą datę
    dzisiejsza_data = datetime.now()
    
    # Obliczamy wiek
    wiek = dzisiejsza_data.year - data_urodzenia.year
    
    # Sprawdzamy, czy użytkownik już obchodził urodziny w tym roku
    if (dzisiejsza_data.month, dzisiejsza_data.day) < (data_urodzenia.month, data_urodzenia.day):
        wiek -= 1  # Jeśli nie, odejmujemy 1 rok
    
    # Wyświetlamy wynik
    print(f"Twój wiek to {wiek} lat.")

# Uruchamiamy kalkulator wieku
kalkulator_wieku()
