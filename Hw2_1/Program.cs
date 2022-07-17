Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());

if(Num/100 > 0)
{
    Console.WriteLine(Convert.ToString(Num)[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}