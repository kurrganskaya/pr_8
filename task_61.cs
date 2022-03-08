// Задача 61: Найти произведение двух матриц.

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] arrayOne = new int[m, n];

void FillArray(int[,] massiv)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arrayOne[i, j] = new Random().Next(0, 10);
        }
    }
}
FillArray(arrayOne);

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
PrintArray(arrayOne);

Console.WriteLine();
int k = n;
int l = m;
int [,] arrayTwo = new int[k,l];
{
     for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < l; j++)
        {
            arrayTwo[i, j] = new Random().Next(0, 10);
            Console.Write(arrayTwo [i,j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();

int [,] resultArray = new int [m, n];
{
     for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultArray[i,j] += arrayOne[i,j] * arrayTwo[j,i];
            Console.Write(resultArray[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
