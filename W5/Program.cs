/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
using static Common.Helper;
int n = UserInputint("enter max number");

if (n % Math.Sqrt(n) != 0)
{
	Console.WriteLine("cannot be converted to a spiral array");
	return;
}

int sizeArray = (int)Math.Sqrt(n);
int[,] array = new int[sizeArray, sizeArray];
SpiralArray(array);
Print2DArray(array);

void SpiralArray(int[,] array)
{
	int countElements = 1;
	int count = 1;
	while (count < array.Length)
	{
		for (int i = countElements - 1; i < array.GetLength(1) - countElements; i++)
		{
			array[countElements - 1, i] = count;
			count++;
		}
		for (int i = countElements - 1; i < array.GetLength(1) - countElements; i++)
		{
			array[i, array.GetLength(1) - countElements] = count;
			count++;
		}
		for (int i = array.GetLength(1) - countElements; i >= countElements; i--)
		{
			array[array.GetLength(1) - countElements, i] = count;
			count++;
		}

		for (int i = array.GetLength(1) - countElements; i >= countElements; i--)
		{
			array[i, countElements - 1] = count;
			count++;
		}
		countElements++;

	}
	if (sizeArray % 2 != 0)
	{
		array[sizeArray / 2, sizeArray / 2] = count;

	}
}
