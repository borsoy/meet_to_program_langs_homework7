// Задача 2: Напишите программу, которая на вход  принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите номер элемента в строке: ");
int position1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите номер элемента в столбеце: ");
int position2 = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 5; 
int m = 7; 
Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
{
    arr[i, j] = random.Next(10, 99);
Console.Write("{0} ", arr[i, j]);
}
Console.WriteLine();
}
    if (position1 < 0 | position1 > arr.GetLength(0) - 1 | position2 < 0 | position2 > arr.GetLength(1) - 1)
{
Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[position1, position2]);
}
Console.ReadLine();