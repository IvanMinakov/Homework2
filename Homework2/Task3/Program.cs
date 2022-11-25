Console.WriteLine("Введите число дня недели");
int a = Convert.ToInt32(Console.ReadLine());
int saturday = 6;
int sunday = 7;
if (a == saturday || a == sunday) Console.WriteLine("Да");
else Console.WriteLine("Нет");