/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

using static Common.Helper;
int m = UserInputint("Enter m");
int n = UserInputint("Enter n");
int[,] array2D = new int[m, n];
FillRandom2DArray(array2D, 0, 11);
Print2DArray(array2D);
Console.WriteLine();
SortLines(array2D);
Print2DArray(array2D);

void SortLines(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
					int count = 0;

		while (count < array.GetLength(1) )
		{
			int idMax = count;
			for (int j = count; j < array.GetLength(1); j++)
			{
				if (array[i, j] > array[i, idMax] )
				{
					idMax = j;
				}
			}
			int temp;
			temp = array[i, count];
			array[i, count] = array[i, idMax];
			array[i, idMax] = temp;
			count++;
		}
	}
}
