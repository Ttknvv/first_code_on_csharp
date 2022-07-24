Console.WriteLine("Введите число A=");
int chisl_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B=");
int chisl_b = Convert.ToInt32(Console.ReadLine());
int num = 1;
int cube = chisl_a;
while(num < chisl_b)
{
    cube = cube * chisl_a;
    num++;
}
Console.WriteLine(cube);