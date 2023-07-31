void FillArray(int[,] matrix, int minValue =-9, int maxValue=9)
{
    maxValue++;
    Random random = new Random();
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0;j<matrix.GetLength(1); j++)
        {
            // Console.WriteLine($"matrix[{i}, {j}]");
            matrix[i,j] = random.Next(minValue,maxValue);
        }
        // Console.WriteLine($"Вывод строки с индексом {i} окончен");
    }
}
void PrintArray(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0;j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
            // \t - табуляция, создает таблицу
        }
        Console.WriteLine();
    }
}

void Task46()
{// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
    int rows = 4;
    int columns = 7;
    int[,] matrix = new int[rows, columns];
// GetLength(0) - метод вызова длины, если 0 строки, если 1 столбца, в данном случае возвращается 4(rows)
// i - индекс строк, j - индекс столбцов
    FillArray(matrix);
    PrintArray(matrix);
}

void Task48()
{// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A = m+n.
// Выведите полученный массив на экран. 
    int rows = 4;
    int columns = 7;
    int[,] matrix = new int[rows, columns];
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0;j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = i+j;
        }
    }
    PrintArray(matrix);
}
void Task49()
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их
// квадраты.
{
    int rows = 8;
    int columns = 8;
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0;j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(-10,10);
        }
    }
    PrintArray(matrix);
    Console.WriteLine();
    for(int i=2; i<matrix.GetLength(0); i=i+2)
    {
        for(int j=2;j<matrix.GetLength(1); j=j+2)
        {
            matrix[i,j] = matrix[i,j]*matrix[i,j];
        }
    }
    PrintArray(matrix);
}

void Task51()
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0);
//(1;1) и т.д.
{
    int rows = 8;
    int columns = 8;
    int[,] matrix = new int[rows, columns];
    FillArray(matrix);
    PrintArray(matrix);
    
    int sum = 0;
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0;j<matrix.GetLength(1); j++)
        {
            if(i == j)
            {
                sum = sum + matrix[i,j];
            }
        }
    }
    Console.WriteLine($"Сумма элементов массива по главной диагонали равна {sum}");
}

Task51();