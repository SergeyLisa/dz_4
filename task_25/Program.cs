// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать библиотеку Math!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int construction(int a, int b)
{
  int result = 1;
  for (int count = 1; count <= b; count++) 
  {
    result = result * a;
  }
  return result;
}

Console.Clear();

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int b = int.Parse(Console.ReadLine()!);
int pow = construction(a, b);
Console.Write(pow);