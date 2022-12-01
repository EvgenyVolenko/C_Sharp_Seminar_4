// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int digit;
int sum = 0;

Console.Write("Введите число A: ");

while (true)
{
    if (int.TryParse(Console.ReadLine(), out digit)) break;
    else Console.Write("Ну просил же ЧИСЛО: ");
}

digit = Math.Abs(digit);

while (digit > 0)
{
    sum = sum + digit % 10;
    digit /= 10;
}
Console.WriteLine($"Выводим сумму цифр в числе {sum}");