Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int d = 0, k = 0;
if (a > 99)
{
    k = a;
    while (k > 100)
    {
        k /= 10;
        d = k % 10;
        Console.WriteLine($"Вторая цифра числа {a} это {d} ");
    }
}
else
{
    Console.WriteLine($"Третье числа нет");
}