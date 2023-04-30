/*int[,] CreateRandom2dArray(int rose, int columns, int minValue, int maxValue)
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
Show2dArray(newArray);*/

//Задать двумерный массив размеров m x n, заполненный случайными вещественными цифрами
/*int[,] CreateRandom2dArray(int rose, int columns, double minValue, double maxValue)
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
double minValue = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите максимально значение массива: ");
double maxValue = Convert.ToDouble(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(rose, columns, minValue, maxValue);
Show2dArray(newArray);*/

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    } 
    Console.WriteLine();
}

Console.Write("Введите количество массивов ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayStrings = new string[size];
int len = 3;
int pos = 0;
for (int i = 0; i < size; i++)
{
    Console.WriteLine($" Введите элементы массива: ");
    string element = Convert.ToString(Console.ReadLine());
    if (element.Length <= len)
    {
        arrayStrings[pos] = element;
        pos ++;
    }
}
Console.WriteLine();
PrintArray(arrayStrings);