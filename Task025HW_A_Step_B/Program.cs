// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

Console.Clear();
int proizv = 1;

Console.Write("Введите число А: ");
int A = EnterDigit();
Console.Write("Введите число B: ");
int B = EnterDigit();

int EnterDigit()
{
    int digit;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out digit)) break;
        else Console.Write("Ну просил же ЧИСЛО: ");
    }
    return digit;
}

for (int i = 0; i < B; i++)
{
    proizv *= A;
}

Console.Write($"Число A в степени B = {proizv}");