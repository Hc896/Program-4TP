import math 
def liczba(num):
    for i in range(2, num + 1):
        for j in range(2, int(math.sqrt(i))+1):
            if i%j == 0:
                print("liczba nie jest pierwsza", i)
                break
        else:
            print("liczba jest pierwsza", i)

liczba(10)