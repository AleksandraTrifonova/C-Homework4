//Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int [] array = new int [12];
int sum = 0;
for (int i = 0; i < array.Length; i++) array [i] = new Random().Next(0,10);
for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
for (int i = 0; i < array.Length; i++)
{
    sum = sum + array [i];
}
Console.WriteLine("");
Console.WriteLine($"Сумма положительных элементов массива равна {sum} ");
Console.WriteLine($"По условию задачи отрицательных элементов в данном массиве нет.");