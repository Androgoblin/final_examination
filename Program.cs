// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// int time_interval(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int NaturalNumber(int n, int m)
// {
//   if (n == m) return n;
//   else Console.Write($"{NaturalNumber(n, m + 1)}, ");
//   return m;
// }

// int n =time_interval ("Введите число N: ");
// if (n < 1)
// {
//   Console.WriteLine("Ввдите положительное число!");
//   return;
// }
// Console.WriteLine(NaturalNumber(n, 1));


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int time_interval(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int SumNaturElements(int n, int m)
// {
//   if (n == m) return n;
//   else return SumNaturElements(n + 1, m) + n;
// }

// int n =time_interval ("Введите N: ");
// int m =time_interval("Введите M: ");

// Console.WriteLine($"Сумма натуральных элементов = { SumNaturElements(n, m)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int Number(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int Akkerman(int m, int n)
// {
//   if (m == 0) return n + 1;
//   if (m > 0 && n == 0) return Akkerman(m - 1, 1);
//   else return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// int m = Number("Введите M: ");
// int n = Number("Введите N: ");

// Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");

 