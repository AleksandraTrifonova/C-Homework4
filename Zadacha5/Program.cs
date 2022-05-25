// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.Write("Введите количество элементов массива: ");
int length = int.Parse(Console.ReadLine()?? "0");
int [] array = new int [length];
for (int i = 0; i < length; i++) array [i] = new Random().Next(1,10);
for (int i = 0; i < length; i++) Console.Write($"{array[i]} ");
int [] muiliplication = new int [length/2];
Console.WriteLine();
Console.WriteLine("Произведение пар чисел в массиве равно: ");
for (int i = 0; i < length/2; i++)
{
    muiliplication[i] = array[i] * array [length - 1 - i];
    Console.Write($"{muiliplication[i]} ");
}
