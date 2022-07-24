Console.WriteLine("Введите число A=");
string chisl = Console.ReadLine();
int sum = 0;
int len = chisl.Length;
int n = 0;
while(n < len)
{
    sum = sum + Convert.ToInt32(""+chisl[n]);
    n++;
}
Console.WriteLine(sum);