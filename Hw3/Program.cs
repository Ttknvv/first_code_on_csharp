Console.WriteLine("Введите число =");
double chisl = Convert.ToDouble(Console.ReadLine());

if(chisl == 0)
{
    Console.WriteLine("Не применимо");
}
else if(chisl%2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Не четное");
}