// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();

int number = GetNumber("Введите положительно число N: ");
bool isCorrect = Validate(number);
if (isCorrect == true)
{
    int pr = PrFromDigits(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} = {pr}");
}
else
{
    Console.WriteLine($"Ну просил же положительное ЧИСЛО.");
}

int GetNumber(string message)
{
    int digit;
    Console.Write(message);
    if (int.TryParse(Console.ReadLine(), out digit)) return digit;
    else return -1;
}

int PrFromDigits(int A)
{
    int count = 0;
    int proizv = 1;
    while (count < A)
    {
        count++;
        proizv *= count;
    }
    return proizv;
}

bool Validate(int dig)
{
    if (dig > 0) 
    {
        return true;
    }
    else
    {
        return false;
    }
}