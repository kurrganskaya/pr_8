// Задача 57: Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
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

void OrderElements(int[,] massiv)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n - 1; j++)
        {
            for (int a = j + 1; a < n; a++)
            {
                if (array[i, j] < array[i, a])
                {
                    int min = array[i, j];
                    array[i, j] = array[i, a];
                    array[i, a] = min;

                }
            }

        }
    }
}
Console.WriteLine("Сортировка элементов строк двумерного массива по убыванию:");
OrderElements(array);
PrintArray(array);
