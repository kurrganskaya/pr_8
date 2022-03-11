Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];

void FillArray(int[,] massiv)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
FillArray(array);

void PrintArray(int[,] massiv)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{massiv[i, j]}  " + "\t");
        }
        Console.WriteLine();
    }
}
PrintArray(array);

int Min(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Count(); i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}

int[] allSum = new int[m];
for (int i = 0; i < m; i++)
{
    int sum = 0;
    for (int j = 0; j < n; j++)
    {
        sum += array[i, j];
        allSum[i] = sum;
    }
    Console.WriteLine($"Сумма элементов {i + 1} строки: {allSum[i]}.\n");
}
Console.WriteLine($"Мин. значение: {Min(allSum)}.");
