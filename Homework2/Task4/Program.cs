int[] array = new int[100];
int n = array.Length;
for (int i = 0; i < n; i++)
{
    array[i] = i + 1;
    if (array[i] % 3 == 0 & array[i] % 15 != 0)
    {
        Console.Write("Fizz, ");
    }
    else if (array[i] % 5 == 0 & array[i] % 15 != 0)
    {
        Console.Write("Buzz, ");
    }
    else if (array[i] % 15 == 0) 
    {
        Console.Write("FizzBuzz, ");
    }
    else
    {
        Console.Write($"{array[i]}, ");
    }
}
