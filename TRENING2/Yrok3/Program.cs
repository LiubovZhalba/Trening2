// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Задача 1: Программа принимает на вход 5-ти значное число и сообщает палинтром это или нет
/*int PalinDrom(int number)
{
    int des1 = number / 10000;
    int ed1 = number / 1000 % 10;
    int des2 = number / 10 % 10;
    int ed2 = number % 10;

    int result = (des1 + ed1) - (des2 + ed2);
    return result;  
}

Console.Write("Введите 5-ти знач.число: ");
int num = Convert.ToInt32(Console.ReadLine());

int newnum = PalinDrom(num);
{
    if(newnum == 0)
    {
        Console.WriteLine("Палиндром: ");
    }
    else
    {
        Console.WriteLine("Не палиндром: ");
    }
}*/
// Задача 2: Программа принимает координаты 2-х точек и находит расстояние между ними в 3-D пространстве

double DlinaOtr(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double L1 = x2 - x1;
    double L2 = y2 - y1;
    double L3 = z2 - z1;
    double result = Math.Sqrt(Math.Pow(L1,2) + Math.Pow(L2,2) + Math.Pow(L3,2));
    return result;
}
Console.Write("Введите координаты х точки А: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты y точки А: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты z точки А: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты х точки В: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты y точки В: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты z точки В: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double Dlina = DlinaOtr(x1, y1, z1, x2, y2, z2);

Console.WriteLine(Math.Round(Dlina));

// Задача 3: Программа принимает на вход N и выдает куб чисел от 1 до N

/*void PrintCub(int N)
{
    int i = 1;
    while(i <= N)
    {
        Console.Write(i * i * i + " ");
        i = i + 1;
    }
}
Console.Write("Введите число элементов: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintCub(N);*/


