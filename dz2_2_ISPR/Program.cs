Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n >= 1000) n /= 10;
int n1 = n % 10;
{
    if (n>=100)
    Console.WriteLine(n1);
    else
    Console.Write("Третьей цифры нет");
}
