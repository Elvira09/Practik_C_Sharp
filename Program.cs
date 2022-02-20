void FillArray(int[] collection)
{
	int index = 0;
	while (index < collection.Length)
	{
		collection[index] = new Random().Next(-50, 50);
		index++;
	}
}

void PrintArray(int[] collection)
{
	for (int i = 0; i < collection.Length; i++)
	{
		Console.Write($"{collection[i]} ");
	}
	Console.WriteLine();
}

int SearchItems(int[] collection)
{
	int count = 0;
	for (int i = 0; i < collection.Length; i++)
	{
		if (collection[i] > 8)
		{
			count++;
		}
	}

	return count;
}

void FillArraySelectedItemsAndPrint(int[] collection)
{
	int[] newCollection = new int[SearchItems(collection)];
	for (int i = 0; i < collection.Length; i++)
	{
		int j = SearchItems(collection) - 1;
		
			if (collection[i] > 8)
			{
				newCollection[j] = collection[i];
				Console.Write($"{newCollection[j]} ");
			}
	}
}

Console.Clear();

int[] array = new int[25];
FillArray(array);
Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine("Результирующий массив: ");
FillArraySelectedItemsAndPrint(array);
// Console.WriteLine();

