// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
int digit, count = 1, pr = 1;

Console.Write("Введите число A которое больше 0: ");

while (true)
{
    if (int.TryParse(Console.ReadLine(), out digit)) break;
    else Console.Write("Ну просил же ЧИСЛО: ");
}

if (digit <= 0) Console.WriteLine("Ну больше же 0 просил.");
else
{
    while (count < digit)
    {
        count++;
        pr *= count;
    }
    Console.WriteLine($"Выводим произведение чисел {pr}");
}