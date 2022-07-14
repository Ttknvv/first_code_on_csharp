Console.WriteLine("Введите число а = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c = ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if(b>max)
{
    max = b;
}
else if(c>max)
{
    max = c;
}

Console.WriteLine("max = ");
Console.WriteLine(max);