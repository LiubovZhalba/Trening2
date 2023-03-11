// ДЗ к Уроку 9 Задача № 1 здесь будет от 5 4 3 2 1 т.к. вывод на консоль идет до отработки условия
/*void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num - 1);
}

ShowNums(8);*/

//ДЗ к уроку 9 Задача № 2
Console.WriteLine("ВВедите число M: ");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("ВВедите число N: ");
int numberN = int.Parse(Console.ReadLine());

void GapNumberSum(int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        Console.WriteLine($"Сумма натур.элементов равна {sum}");
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}   

GapNumberSum(numberM, numberN, 0);

//ДЗ к 9 уроку Задача № 3
/*Console.WriteLine("Введите число M: ");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());

int AckermanFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermanFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermanFunction(numberM - 1, AckermanFunction(numberM, numberN - 1));
 return AckermanFunction(numberM, numberN);
}


Console.WriteLine($"Функция Аккермана для чисел А({numberM},{numberN} = {AckermanFunction(numberM, numberN)}");*/

