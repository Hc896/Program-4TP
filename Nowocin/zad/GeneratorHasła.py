import random
import string

def generator_hasla(dlugosc=12):
    # Definiujemy zestaw znaków, z których będziemy losować
    znaki = string.ascii_letters + string.digits + string.punctuation
    
    # Losujemy hasło z podanych znaków
    haslo = ''.join(random.choice(znaki) for _ in range(dlugosc))
    
    # Zwracamy wygenerowane hasło
    return haslo

# Uruchamiamy generator i wyświetlamy wygenerowane hasło
dlugosc_hasla = int(input("Podaj długość hasła: "))
print("Wygenerowane hasło:", generator_hasla(dlugosc_hasla))
