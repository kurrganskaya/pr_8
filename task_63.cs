// Задача 63: Сформировать трёхмерный массив с не повторяющимися двузначными числами и вывести его на экран построчно, с индексами элементов.

Console.Write("Введите количество страниц массива: ");
int p = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,,] array = new int[p, m, n];

void FillArray(int[,,] massiv)
{
    for (int l = 0; l < p; l++)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[l, i, j] = new Random().Next(10, 99);

            }
        }
    }
}
FillArray(array);

void PrintArray(int[,,] massiv)
{
    for (int l = 0; l < p; l++)
    {
        Console.WriteLine($"Страница {l + 1}");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(" [{0},{1},{2}] {3}", l, i, j, array[l, i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
Console.WriteLine();

PrintArray(array);
