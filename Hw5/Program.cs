void Fillarray(int[] array, int start, int end)
{
    int size = array.Length;
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = rand.Next(start, end);
    }
}

void Fillarraydouble(double[] array, int start, int end)
{
    int size = array.Length;
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.Next(start, end) + rand.NextDouble(), 2);
        
    }
}

void Printarray(int[] array)
{
    int size = array.Length;
    for(int i = 0; i < size; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write("\b\b");
    Console.WriteLine();
}

void Printarraydouble(double[] array)
{
    int size = array.Length;
    for(int i = 0; i < size; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write("\b\b");
    Console.WriteLine();
}

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

void Zadacha_34()
{

    int[] array = new int[4];
    int count = 0;
    Fillarray(array, 100, 1000);

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
        {
            count++;
        }
    }
    Printarray(array);
    Console.Write($"Количество четных чисел - {count}");
}
//Zadacha_34();

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

void Zadacha_36()
{
    int[] array = new int[4];
    int sum = 0;
    Fillarray(array, -10, 11);

    for(int i = 1; i < array.Length; i++)
    {
        if(i%2 != 0)
        {
            sum = sum + array[i];
        }
    }
    Printarray(array);
    Console.Write($"Сумма элементов, стоящих на нечетных позициях - {sum}");
}
//Zadacha_36();

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

void Zadacha_38()
{
    double[] array = new double[4];
    int size = array.Length;
    Fillarraydouble(array, -999, 1000);
    Printarraydouble(array);

    for(int i = 0; i < size; i++)
    {
        for(int j = 0; j < size - i - 1; j++)
        {
            if(array[j] < array[j+1])
            {
                double temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
            }
        }
    }
    double diff = Math.Round(array[0] - array[size - 1], 2);
    Console.Write($"Разница между максимальным ({array[0]}) и минимальным ({array[size - 1]}) элементов массива - {diff}");

}
//Zadacha_38();