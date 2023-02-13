// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void Dellet(String[] args)
{
  Console.WriteLine("Введите число: ");
  int a = int.Parse(Console.ReadLine()!);
  int sum = 0;
  int n = 0;
  {
    while (a > 0)
    {
      n = a % 10;
      sum = sum + n;
      a = a / 10;
    }
    Console.WriteLine($"Сумма числа: {sum}");
  }
}
Dellet(args);