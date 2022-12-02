// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем

Console.Clear();
int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите значение элемента массива в позиции [{i}]: ");
    array[i] = EnterDigit();
}

PrintArray(array);

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

void PrintArray (int[] col)
{
    Console.WriteLine($"У нас получился следующий массив [{string.Join(", ", col)}]");
}