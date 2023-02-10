

Console.Write("Введите число: ");
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



