/* Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Write("Укажите размер массива N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] array = new int[n];
int countOfDigit = 0;
Console.Write($"Массив N случайных чисел:");

for(int i = 0; i < n; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write($" {array[i]}");
    int tmp = array[i];

    while(tmp > 0)
    {  
        if(tmp%2 == 0 && tmp%10 != 0)
        {
            countOfDigit++;
        }
        tmp /= 10;        
    }
}
Console.WriteLine();
Console.Write($"Кол-во четных чисел в массиве: {countOfDigit}");