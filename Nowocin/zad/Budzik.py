import time
from datetime import datetime

def budzik():
    # Pobieramy godzinę i minutę od użytkownika
    godzina = int(input("Ustaw godzinę budzika (0-23): "))
    minuta = int(input("Ustaw minutę budzika (0-59): "))

    # Ustawiamy czas budzika
    print(f"Budziki ustawiony na {godzina:02d}:{minuta:02d}.")

    while True:
        # Sprawdzamy aktualny czas
        teraz = datetime.now()
        godzina_teraz = teraz.hour
        minuta_teraz = teraz.minute

        # Sprawdzamy, czy to już czas na budzik
        if godzina_teraz == godzina and minuta_teraz == minuta:
            print("Czas wstać! Budzik zadzwonił!")
            break  # Kończymy działanie programu po wywołaniu budzika
        
        # Czekamy 60 sekund przed kolejną próbą
        time.sleep(60)

# Uruchamiamy budzik
budzik()
