// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();

int number = GetNumber("Введите неотрицательно число A: ");
bool isCorrect = Validate(number);
if (isCorrect == true)
{
    if (number == 0) Console.WriteLine("Колличество цифр в числе = 1");
    else
    {
        int sum = SumFromDigits(number);
        Console.WriteLine($"Колличество цифр в числе = {sum}");
    }    
}
else
{
    Console.WriteLine($"Невозможно получить колличество цифр.");
}

int GetNumber(string message)
{
    int digit;
    Console.Write(message);
    if (int.TryParse(Console.ReadLine(), out digit)) return digit;
    else return -1;
}

int SumFromDigits(int A)
{
    int count = 0;
    while (A > 0)
    {
        count++;
        A /= 10;
    }
    return count;
}

bool Validate(int dig)
{
    if (dig >= 0) 
    {
        return true;
    }
    else
    {
        return false;
    }
}