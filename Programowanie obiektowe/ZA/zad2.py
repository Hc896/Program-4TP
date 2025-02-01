zloty = float(input("Ile złoty: ")) 
kurs = float(input("Kurs zł na dolary: "))  
wynik = zloty / kurs  
print(wynik)  


fraza = input("Wprowadź frazę: ")
slowa = fraza.split()
liczba_slow = len(slowa)
print(f"Liczba słów w wprowadzonej frazie: {liczba_slow}")

tekst = input("Podaj łańcuch tekstowy: ")
odwrocony_tekst = tekst[::-1]
print(odwrocony_tekst)

liczba = input("podaj liczbą całkowitą: ")

suma = sum(int(cyfra) for cyfra in liczba)

print(suma)