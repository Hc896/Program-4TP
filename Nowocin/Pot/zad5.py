import random

class ArrayOperations:
    def __init__(self, size):
        self.__size = size  
        self.__array = [random.randint(1, 1000) for _ in range(size)]  
    
    def display(self):
       
        for i, val in enumerate(self.__array):
            print(f"{i}: {val}")
    
    def find(self, value):
       
        try:
            return self.__array.index(value)
        except ValueError:
            return -1
    
    def display_odds(self):
       
        odds = [num for num in self.__array if num % 2 != 0]
        print("Nieparzyste liczby w tablicy:", odds)
        return len(odds)
    
    def calculate_average(self):
      
        return sum(self.__array) / self.__size

def main():
    size = 25 
    array_ops = ArrayOperations(size)
    
    print("Tablica liczb:")
    array_ops.display()
    
    search_value = int(input("Podaj liczbę do wyszukania: "))
    index = array_ops.find(search_value)
    if index != -1:
        print(f"Liczba {search_value} znajduje się pod indeksem {index}.")
    
    odd_count = array_ops.display_odds()
    print(f"Liczba nieparzystych wartości w tablicy: {odd_count}")
    
    average = array_ops.calculate_average()
    print(f"Średnia arytmetyczna wartości w tablicy: {average:.2f}")

if __name__ == "__main__":
    main()
