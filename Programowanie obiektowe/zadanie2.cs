// Pętla główna iteruje przez liczby od 7 do 20
for (let number = 7; number <= 20; number++) {
    let check = true; // Flaga sprawdzająca, czy liczba jest podzielna przez inne liczby
    
    // Pętla wewnętrzna iteruje przez liczby od 7 do bieżącej liczby (number)
    for (let test = 7; test < number; test++) {
        // Sprawdzanie, czy liczba 'number' jest podzielna przez 'test'
        if (number % test === 0) {
            check = false; // Jeśli liczba jest podzielna, ustaw flagę na false
            break; // Przerwij pętlę wewnętrzną, ponieważ nie jest liczbą pierwszą
        }
    }
    
    // Jeśli flaga pozostała true, wypisz liczbę, bo nie jest podzielna przez żaden 'test'
    if (check) {
        console.log(number);
    }
}


// Pętla główna iteruje przez liczby od 9 do 20
for (let number = 9; number <= 20; number++) {
    let check = true; // Flaga sprawdzająca, czy liczba jest podzielna przez inne liczby
    
    // Pętla wewnętrzna iteruje przez liczby od 9 do bieżącej liczby (number)
    for (let test = 9; test < number; test++) {
        // Sprawdzanie, czy liczba 'number' jest podzielna przez 'test'
        if (number % test === 0) {
            check = false; // Jeśli liczba jest podzielna, ustaw flagę na false
            break; // Przerwij pętlę wewnętrzną, ponieważ liczba nie jest liczbą pierwszą
        }
    }
    
    // Jeśli flaga pozostała true, wypisz liczbę, bo nie jest podzielna przez żaden 'test'
    if (check) {
        console.log(number); // Wyświetlenie liczby, jeśli jest "pierwsza" w tym kontekście
    }
}

