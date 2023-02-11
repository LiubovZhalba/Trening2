// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Задача 1:в программу вводят 3-х значное число, 
//а на выходе плучают 2-ую цифру этого числа
//Console.Write("Введите 3-х значное число: ");
//int num = Convert.ToInt32(Console.ReadLine());

//int result = (num / 10 % 10);
//Console.WriteLine(result);

//Задача 2: программа выводит третью цифру заданного числа

//int CutNumber(int number)
//{
//  int index = 0;
//  int result = 0;
//  int max = 3;

//    while(index < max)
//    {   
//      result = number / 10;
//      index++;
//    }
//    return result;
//}

//Console.Write("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());

//int newNum = CutNumber(num);
//int newNum2 = newNum % 10;

//Console.WriteLine(newNum2);
// Задача 3: программа принимает на вход цифру обозначающую день недели
//и выводит true, если это 6 или 7 день и faise если остальные дни.
bool DenNed(int number)
{
  bool result = false;

    if(number % 6 == 0 || number % 7 ==0)
    {
      result = true;
    }
    return result;
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result2 = DenNed(num);
Console.WriteLine(result2);