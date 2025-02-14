//1. A) zmienna to cecha właściwość lub czynnik, przyjmujący różne wartości. B) Typy danych to klasyfikacja, która mówi o rodzaju danych, które mogą być przetwarzane i przechowywane w komputerze.
int myInt = 5; //A
Console.WriteLine(sizeof(int)); // Wyświetli 4 bajty

string myString = "Hello";
Console.WriteLine(sizeof(char) * myString.Length); // Wyświetli ilość bajtów równą długości napisu

int* ptr = &myInt; //B wskaźnik na zmienną myInt

//2. Do typów prostych należą dane liczbowe takie jak: „int”, „float”, itd., a także typy wyliczeniowe oraz struktury.
int myInt = 5;
ushort myUshort = 65535;
float myFloat = 3.14f;
bool myBool = true;
string myString = "Hello, World!";

//3. W języku C# istnieją następujące typy numeryczne:
//sbyte: 8-bitowy typ całkowity, reprezentujący wartości od 0 do 255.
//byte: 8-bitowy typ całkowity, reprezentujący wartości od 0 do 255.
//short: 16-bitowy typ całkowity, reprezentujący wartości od -32768 do 32767.
//int: 32-bitowy typ całkowity, reprezentujący wartości od -2147483648 do 2147483647.
//long: 64-bitowy typ całkowity, reprezentujący wartości od -9223372036854775808 do 9223372036854775807.
//float: 32-bitowy typ liczby zmiennoprzecinkowej, reprezentujący wartości od -3,4E+38 do 3,4E+38.
//double: 64-bitowy typ liczby zmiennoprzecinkowej, reprezentujący wartości od -1,8E+308 do 1,8E+308.
using System;

class NumericTypesExample
{
    static void Main(string[] args)
    {
        int x = 5; // 32-bit signed integer
        uint y = 5u; // 32-bit unsigned integer
        long z = 5L; // 64-bit signed integer
        ulong w = 5UL; // 64-bit unsigned integer

        float f = 3.14f; // 32-bit floating-point number
        double d = 3.14; // 64-bit floating-point number
        decimal m = 3.14m; // 128-bit decimal floating-point number

        byte b = 5; // 8-bit unsigned integer

        Console.WriteLine($"x: {x}, y: {y}, z: {z}, w: {w}");
        Console.WriteLine($"f: {f}, d: {d}, m: {m}");
        Console.WriteLine($"b: {b}");
    }
}

//4. W języku C# istnieją następujące typy znakowe:

//char: reprezentuje pojedynczy znak, np. ‘a’ lub ‘\n’
//string: reprezentuje ciąg znaków, np. “hello” lub @“C:\Path\to\file”
//Warto zauważyć, że w C# nie ma bezpośredniego odpowiednika operatora := z języka Pascal. W C# operator = jest używany do przypisania wartości zmiennych.

//Wartości liczbowe w C# są reprezentowane przez następujące typy:

//int: 32-bitoweliczby całkowite
//long: 64-bitowe liczby całkowite
//float: liczby zmiennopozycyjne pojedynczej dokładności
//double: liczby zmiennopozycyjne podwójnej dokładności

char c = 'a'; // pojedynczy znak
string str = "hello"; // ciąg znaków

//5. W języku C# typy logiczne są reprezentowane przez dwa stałe wartości: true (prawda) i false (fałsz). Te typy są używane w warunkach if, switch, a także w operacjach logicznych takich jak && (i), || (lub), ! (negacja).

//Operatory logiczne

//W C# operatory logiczne są następujące:

//&& (i) - operator logiczny AND (wykonuje operację tylko jeśli oba argumenty są prawdziwe)
//|| (lub) - operator logiczny OR (wykonuje operację jeśli co najmniej jeden z argumentów jest prawdziwy)
//! (negacja) - operator negacji (odwraca wartość logiczną)
public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

Point point = new Point { X = 10, Y = 20 }

//6. W C# istnieje wiele metod, które mogą być użyte do operacji na łańcuchach, takich jak:

//Concat() - łączy dwa łańcuchy
//Substring() - wyodrębnia fragment łańcucha
//IndexOf() - szuka znaku lub łańcucha w innym łańcuchu
//Replace() - zastępuje znaki lub łańcuchy w łańcuchu
//Łańcuchy w C# - krótki przegląd

//W C# łańcuchy są niezmienne, dynamicznie przydzielane, i obsługiwane przez wiele metod. Są one kluczowym typem danych w programowaniu w języku C#.
string firstName = "John";
string lastName = "Doe";
string fullName = firstName + " " + lastName; // Output: "John Doe"

//7. Typowanie dynamiczne (dynamiczne) pozwala na zmianę typu zmiennej w trakcie działania programu, bez konieczności deklaracji typów przed kompilacją. Przykładem jest JavaScript, gdzie deklaracja zmiennej może być zmieniona w czasie wykonywania programu, co nie jest możliwe w językach statycznie typowanych, takich jak C#.

//Różnice między JavaScriptem a C#

//JavaScript: dynamiczne typowanie, zmiana typu zmiennej w trakcie wykonywania programu
//C#: statyczne typowanie, konieczność deklaracji typów przed kompilacją, brak możliwości zmiany typu zmiennej w trakcie wykonywania programu