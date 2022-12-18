/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

using static Common.Helper;
int m = UserInputint("enter the size of the rectangular array");

int[,] array2D = new int[m, m];
FillRandom2DArray(array2D, 0, 11);
Print2DArray(array2D);
Console.WriteLine();

int result = GetMinElement(GetArrayMinimumSumRow(array2D));
Console.WriteLine($"{result} row");


int[] GetArrayMinimumSumRow(int[,] array)
{
	int[] arrayMininuSumRow = new int[array.GetLength(1)];
	for (int i = 0; i < array.GetLength(0); i++)
	{
		int sumRow = 0;
		for (int j = 0; j < array.GetLength(1); j++)
		{
			sumRow += array[i, j];
		}
		arrayMininuSumRow[i] = sumRow;
	}
	return arrayMininuSumRow;
}

int GetMinElement(int[] array)
{
	int min = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[min] > array[i])
		{
			min = i;
		}
	}
	min++;
	return min;
}