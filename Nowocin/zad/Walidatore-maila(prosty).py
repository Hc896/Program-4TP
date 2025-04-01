import re

def walidator_emaila():
    # Pobieramy adres e-mail od użytkownika
    email = input("Podaj adres e-mail: ")
    
    # Prosty wzorzec dla poprawnego e-maila
    wzorzec = r'^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$'
    
    # Sprawdzamy, czy e-mail pasuje do wzorca
    if re.match(wzorzec, email):
        print("Adres e-mail jest poprawny.")
    else:
        print("Adres e-mail jest niepoprawny.")

# Uruchamiamy walidator
walidator_emaila()
