// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();


Console.Write("Введите положительное число A: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int index = 1;
if (a <= 0) Console.WriteLine("Число меньше 0, запустите программу заново.");
else
{
    while (index <= a)
    {
        sum += index;
        index++;
    }
    Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");
}

