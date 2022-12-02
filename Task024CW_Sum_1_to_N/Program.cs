// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();

int number = GetNumber("Введите положительное число A: ");
bool isCorrect = Validate(number);
if (isCorrect == true)
{
    int sum = Sum1toA(number);
    Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");
}
else
{
    Console.WriteLine($"Невозможно получить сумму от 1 до {number}.");
}

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum1toA(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum += i;
    }
    return sum;
}

bool Validate(int number)
{
    if (number > 1)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Число меньше 0, запустите программу заново.");
        return false;
    }
}