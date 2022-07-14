Console.WriteLine("Введите число =");
double chisl = Convert.ToDouble(Console.ReadLine());
int numb = 1;
while(numb != chisl)
{
    if(numb%2 == 0)
    {
        Console.WriteLine(numb);
    }
    numb++;
}
