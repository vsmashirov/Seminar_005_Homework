/* Задача 3*: Задайте массив натуральных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
int Min(int min, int digit) // функция поиска мин. числа среди двух чисел
{
    if(min > digit)
    {
        return min = digit;
    }  
    else 
    {
        return min;
    }
}
int Max(int max, int digit) // функция поиска макс. числа среди двух чисел
{
    if(max < digit)
    {
        return max = digit;
    }
    else 
    {
        return max;
    }
}

Console.Write("Укажите размер массива N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] array = new int[n];

Console.Write($"Массив N случайных чисел:");
for(int i = 0; i < n; i++) // заполняем массив
{ 
    array[i] = new Random().Next(1,100);
    Console.Write($" {array[i]}");
}

int max = 0;
int min = 0;
for (int i = 0; i < n-1; i++) // ищем мин. и макс. значение в массиве
{
    if (i == 0)
    {
        min = array[i];
        max = array[i];
    }
    else
    {
        min = Min(min, array[i]);
        max = Max(max, array[i]);

    }
    for(int j = 1; j < n; j++)
    {
        min = Min(min, array[j]);
        max = Max(max, array[j]);
    }
}
int result = max - min;
Console.WriteLine();
Console.WriteLine($"разница между максимальным и минимальным элементов массива = {result}");