// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int a=0;
// for(int i=10;i<=n;i++)
// {a=n/i;
// }
// Console.WriteLine(a);

// task 26

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 1;
while (n / 10 != 0)
{
    n /= 10;
    count++;
}
Console.WriteLine(count);
