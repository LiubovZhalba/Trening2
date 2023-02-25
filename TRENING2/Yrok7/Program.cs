int[,] CreateRandom2dArray(int rose, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rose, columns];

    for(int i = 0; i < rose; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + " ");

            Console.WriteLine();
        }
        Console.WriteLine();
}

Console.Write("Введите количество строк: ");
int rose = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально значение массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(rose, columns, minValue, maxValue);
Show2dArray(newArray);
