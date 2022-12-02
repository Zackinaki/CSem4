// task 28

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), result = 1;
for (int i = 2; i <= n; i++)
    result = result * i;
Console.WriteLine($"Результат: {result}");
