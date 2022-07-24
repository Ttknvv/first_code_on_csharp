int[] mas = {-1, -3, -2, -6, 0, 5, 3, 2, 4};
int len = mas.Length;
int pos_max = mas[0];

for (int i = 0; i < len; i++)
{
    for (int j = 0; j < len - 1 - i; j++)
    {
        if(Math.Abs(mas[j]) > Math.Abs(mas[j + 1]))
        {
            int help_perem = mas[j];
            mas[j] = mas[j+1];
            mas[j+1] = help_perem;
        }
    }
}

for (int i = 0; i < len; i++)
{
    Console.Write(mas[i]+ ",");
}