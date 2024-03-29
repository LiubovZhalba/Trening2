﻿//Ввести с клавиатуры М чисел и посчитать сколько чисел больше 0 ввел пользователь
/*int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] InputArray(int length)
{
    int [] array = new int[length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1} элеиент");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = Prompt("Введите количество элментов >");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Кол-во числе больше 0 - {CountPositiveNumbers(array)}");*/

//Задача 2: Написать программу, которая найдет точку пересечения 2-х прямых заданных уравнений
//y=k1*x+b1, y=k2*x+b2. Значения b1 b2 k1 k2 задаются пользователем
const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if (ValidataLines(lineData1, lineData2))
{
    double[] coord = FineCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений
    y={lineData1[COEFFICIENT]}*x+{lineData1[CONSTAN]} и
    y={lineData2[COEFFICIENT]}*x+{lineData1[CONSTAN]}");

    Console.WriteLine($" имеет координаты ({coord[X_COORD]}, {coord[Y_COORD]})");
}

double Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEFFICIENT] = Prompt($"Введите коэф.для {numberOfLine} прямой >");
    lineData[CONSTANT] = Prompt($"Введите константу для {numberOfLine} прямой >");
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
double[] coord = new double[2];
coord[X_COORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / 
(lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
coord[Y_COORD] = lineData1[CONSTANT] * coord[X_COORD] +
lineData1[CONSTANT];
return coord;
}

bool ValiDataLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
    {
        Console.WriteLine("Прямые совпадают");
        return false;
    }
    else
    {
        Console.WriteLine("Прямые параллельны");
        return false;
    }
    return true;
}