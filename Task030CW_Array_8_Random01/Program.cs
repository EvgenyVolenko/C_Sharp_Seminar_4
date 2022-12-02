// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
}

PrintArray(array);

Console.WriteLine($"[{string.Join(", ", array)}]"); // Хороший вариант печати данных массива на экран.

void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine($"Позиция в массиве {position} значение {col[position]}.");
        position++;
    }
}