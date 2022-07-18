HEAP - Kopiec
Zadanie polega na zaimplementowaniu kopca min-heap przechowującego liczby całkowite z zakresu [-109..109]. Należy zaimplementować operacje budowy kopca z dowolnej tablicy liczb oraz operację ekstrakcji najmniejszego elementu (wierzchołka kopca).

W funkcji heapify, w przypadku gdy obaj synowie mają równą wartość należy wybrać lewego syna.

Wejście:
W pierwszym wierszu podana jest liczba testów. Dalej znajdują się kolejne testy.

Dla każdego testu wpierw podana jest liczba n, a następnie n liczb na podstawie których należy zbudować kopiec (liczby należy wczytać do tablicy i używając funkcji BuildHeap utworzyć kopiec). W kolejnym wierszu znajduje się liczba m i kolejno m wierszy zawierających jedną literę E lub P.

Wyjście:
Dla każdej instrukcji E lub P należy wypisać w jednym wierszu:

Dla każdej litery P należy wypisać aktualny stan kopca (wypisać zawartość tablicy, oddzielając kolejne liczby spacjami).
Dla każdej litery E należy wykonać ekstrakcję elementu najmniejszego, tzn. wypisać element najmniejszy i usunąć z kopca (z zachowaniem własności kopca).
Przykład
Wejście:
2
10
3
-14
-3
15
13
-5
6
-8
-11
1

6
P
E
E
P
E
E

10
-18
7
-10
-1
-17
-14
0
6
-8
-4

6
P
E
E
P
E
E


Wyjście:
-14 -11 -5 -8 1 -3 6 3 15 13
-14
-11
-8 1 -5 3 15 -3 6 13
-8
-5
-18 -17 -14 -8 -4 -10 0 6 -1 7
-18
-17
-14 -8 -10 -1 -4 7 0 6
-14
-10
