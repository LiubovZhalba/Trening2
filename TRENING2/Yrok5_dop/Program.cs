// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// ДОМАШНЕЕ ЗАДАНИЕ К УРОКУ 5. 
//Задача 1: Задать массив, заполненный случайными 3=х зн.числами и написать программу, которая показвает количество четных чисел в массиве

/*int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);   
    } 
    return array;
}

void ShowArray( int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int SumIndexNumber(int[] array)
{
    int curent = 0;
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            curent = curent + 1;//sum = sum + array[i]
    }
    return curent;
}
 
Console.Write("Введите количество элементов: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин.позицию: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс.позицию: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

int sumNumber = SumIndexNumber(myArray);
Console.WriteLine("Количетво четных элементов: " + sumNumber);*/

//Задача 2: Задать одномерный массив запол.случайными числами и найти сумму элементов, стоящих на нечетных позициях
/*int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);   
    } 
    return array;
}

void ShowArray( int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int GetSumPosition(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
            sum += array[i]; //sum = sum + array[i]
    }
    return sum;
}
 
Console.Write("Введите количество элементов: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин.позицию: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс.позицию: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

int sumPosition = GetSumPosition(myArray);
Console.WriteLine("Сумма элементов на нечетных позициях: " + sumPosition);*/

//Задача 3: задать массив вещественных чисел и найти разницу между максим. и миним элементами массива
double[] array = {3, 7, 22, 2, 78};
double max = array[0];
double min =  array[0];
if(array[0] >= array[1]) max = array[0];
if(array[1] >= array[2]) max = array[1];
if(array[2] >= array[3]) max = array[2];
if(array[3] >= array[4]) max = array[3];
if(array[4] >= array[4]) max = array[4];
if(array[0] <= array[1]) min = array[0];
if(array[1] <= array[2]) min = array[1];
if(array[2] <= array[3]) min = array[2];
if(array[3] <= array[4]) min = array[3];
if(array[4] <= array[4]) max = array[4];
double result = max - min;
Console.WriteLine(result);