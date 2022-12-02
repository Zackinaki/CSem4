void numbersMax(ref int a)
{
    a = a + 10;
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
numbersMax(ref n);
Console.WriteLine(n);
