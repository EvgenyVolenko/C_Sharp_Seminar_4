// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
int digit, count = 0;

Console.Write("Введите число A: ");

while (true)
{
    if (int.TryParse(Console.ReadLine(), out digit)) break;
    else Console.Write("Ну просил же ЧИСЛО: ");
}

if (digit == 0) Console.WriteLine("Выводим число цифр в числе 1");
else
{
    digit = Math.Abs(digit);

    while (digit % 10 > 0)
    {
        count++;
        digit /= 10;
    }
    Console.WriteLine($"Выводим число цифр в числе {count}");
}