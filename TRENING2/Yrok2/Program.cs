// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int num = Convert.ToInt32(Console.ReadLine());

//int[]array =  {1,2,3,4,25,65,89};
//int n = array.Length;
//int find = 3;
//int index = 0;

//while(index<n)
//{
//    if(array[index] == find)
 //   {
//        Console.WriteLine(index);
//    }
//    index = index + 1;
//}
// Задача: на входе 3-х знач.число, н выходе 1-ая и 3я цифр этого числа

//int CutNamber(int number)
//{
 //   int sot = number / 100;
 //   int ed = number % 10;
//
  //  int result = sot * 10 + ed;
    //return result;
//}

//console.write("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine()); - можно записать по другому:
//int num = new Random().Next(1, 1000);

//int newNam = CutNamber(num);
//Console.WriteLine($"новая версия {num} это {newNam}");

//Задача:bool принимает на вход 2 числа и говорит является одно 
//кратным другому (ДА/НЕТ) 

//bool IsKratno(int num1, int num2);


//bool result = IsKratno();

//Console.WriteLine(result


int CutNumber(int number);
{
    int number = 1;
    int index = 0;
    int result = 0;

        while(index<3)
        {   
        result = number / 10;
        index++;
        }
        return result;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int newNam = CutNumber(num);
int newNam2 = newNam % 10;

Console.WriteLine(newNam2);
