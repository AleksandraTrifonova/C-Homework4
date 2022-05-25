// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int [] array = new int [15];
int count1 = 0;
int count2 = 0;
for (int i = 0; i < array.Length; i++) array [i] = new Random().Next(100,1000);
for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) count1++;
    else count2++;
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел равно {count1} ");
Console.WriteLine($"Количество нечетных чисел равно {count2} ");
