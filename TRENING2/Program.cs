int PalinDrom(int number)
{
    int des1 = number / 10000;
    int ed1 = number % 1000;
    int des2 = number / 100;
    int ed2 = number % 10;

    int result = (des1 * 10 + ed1) / (des2 * 10 + ed2);
    return result;  
}

/*Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[]array =  {1,2,3,4,25,65,89};
int n = array.Length;
int find = 3;
int index = 0;

while(index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index = index + 1;
}



