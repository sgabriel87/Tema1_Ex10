/*Scrieti un program care sa va afisa suma cifrelor ununi numar intreg citit de la
tastatura.
Numarul are exact 2 cifre*/

Console.WriteLine("Introduceti un numar întreg cu exact doua cifre:");
int numar = Convert.ToInt32(Console.ReadLine());

// Extragem prima cifră prin impartire
int cifra1 = numar / 10;

// Extragem a doua cifra prin calculul restului
int cifra2 = numar % 10;

// Calculam suma
int sumaCifrelor = cifra1 + cifra2;

Console.WriteLine("Suma cifrelor numarului {0} este {1}", numar, sumaCifrelor);

