/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
 добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
using static Common.Helper;
int m = UserInputint("enter size of the array");
Console.WriteLine();
int[,,] array3d = new int[m, m, m];
FillRandom3DArray(array3d);
Print3dArray(array3d);

void FillRandom3DArray(int[,,] array3d)
{
	int[] arrayNumber = new int[array3d.Length];
	Random random = new Random();
	int num;
	int count = 0;
	for (int i = 0; i < array3d.GetLength(0); i++)
	{
		for (int j = 0; j <  array3d.GetLength(1); j++)
		{
			for (int k = 0; k <  array3d.GetLength(2); k++)
			{
				num = random.Next(10, 100);
				while (FindNumbersInArray(arrayNumber, num))
				{
					num = random.Next(10, 100);
				}
				arrayNumber[count] = num;
				count++;
				array3d[i, j, k] = num;
			}
		}
	}
}

bool FindNumbersInArray(int[] array, int num)
{
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] == num)
		{
			return true;
		}
	}
			return false;
}

void Print3dArray(int[,,]array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			for (int k = 0; k < array.GetLength(2); k++)
			{
				Console.Write($"{array[i,j,k]} ({i},{j},{k}) ");
			}
			Console.WriteLine();
		}
	}
}
