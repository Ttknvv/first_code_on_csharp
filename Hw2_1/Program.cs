Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int numerik = Num;

if(Num>99)
{
    while(numerik>999)
    {
        numerik = numerik/10;
    }
    Console.WriteLine(numerik%10);
}
else
{
    Console.WriteLine("третьей цифры нет");
}

/*
if(Num/100 > 0)
{
    Console.WriteLine(Convert.ToString(Num)[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}*/