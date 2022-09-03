/* Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).
[3, 7, 23, 12] -> 12
[4, 6, 8, 1, 4] -> 6
*/

Console.Write("Укажите размер массива N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] array = new int[n];
int sum = 0;

Console.Write($"Массив N случайных чисел:");
for(int i = 0; i < n; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write($" {array[i]}");
    if((i)%2 > 0 && array[i]%2 == 0)
    {
        sum += array[i];
    }
}
Console.WriteLine();
Console.Write($"Сумма четных чисел на нечетных позициях = {sum} ");