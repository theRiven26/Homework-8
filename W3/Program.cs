/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

using static Common.Helper;
int m = UserInputint("enter the size of the rectangular array");
Console.WriteLine();
int[,] array1 = new int[m, m];
FillRandom2DArray(array1, 0, 11);
Print2DArray(array1);
Console.WriteLine();
int[,] array2 = new int[m, m];
FillRandom2DArray(array2, 0, 11);
Print2DArray(array2);
Console.WriteLine();

Print2DArray(GetMultiplicationArray(array1, array2));

int[,] GetMultiplicationArray(int[,] array1, int[,] array2)
{
	int[,] multiArray = new int[array1.GetLength(0), array1.GetLength(1)];
	for (int i = 0; i < array1.GetLength(0); i++)
	{
		for (int j = 0; j < array1.GetLength(1); j++)
		{
			multiArray[i, j] = array1[i, j] * array2[i, j];
		}
	}
	return multiArray;
}