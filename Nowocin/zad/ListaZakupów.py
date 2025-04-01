def lista_zakupow():
    lista = []  # Pusta lista zakupów
    
    while True:
        print("\nMenu:")
        print("1. Dodaj produkt do listy zakupów")
        print("2. Usuń produkt z listy zakupów")
        print("3. Wyświetl listę zakupów")
        print("4. Zakończ program")
        
        wybor = input("Wybierz opcję (1/2/3/4): ")
        
        if wybor == '1':
            produkt = input("Podaj nazwę produktu do dodania: ")
            lista.append(produkt)
            print(f"Produkt '{produkt}' został dodany do listy zakupów.")
        
        elif wybor == '2':
            if lista:
                print("Produkty na liście zakupów:")
                for idx, produkt in enumerate(lista, 1):
                    print(f"{idx}. {produkt}")
                numer = int(input("Wybierz numer produktu do usunięcia: "))
                if 1 <= numer <= len(lista):
                    usunięty_produkt = lista.pop(numer - 1)
                    print(f"Produkt '{usunięty_produkt}' został usunięty z listy.")
                else:
                    print("Nieprawidłowy numer.")
            else:
                print("Lista zakupów jest pusta.")
        
        elif wybor == '3':
            if lista:
                print
