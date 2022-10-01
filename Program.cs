// ВСЕ ЗАДАЧИ РЕШАЕМ ЧЕРЕЗ МЕТОДЫ

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*Console.WriteLine("Введите число : ");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите степень : ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Результат возведения числа {A} в степень {B} = {GetFact()}"!);

int GetFact()
{
int number = A;
int result = A;
int fact = B;
  for (int i = 1; i < fact; i++)
  {
    result = result * number;
  }
return result;
}*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число : ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа {a} равна {GetSum()}");

int GetSum()
{
int sum = 0;
int b = a;
while (b > 0)
  {
  sum = sum + b % 10;
  b = b / 10 ;
  }
return sum;
}

// Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

