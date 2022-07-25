/*int[] polind(string mass)
{
    int n = mass.Length;
    int[] mss = new int[n];
    int i = 0;
    while(i < n)
    {
        mss[i] = mass[n-i];
        i++; 
    }
    return mss;
}

Console.WriteLine(polind("123345"));*/

Console.WriteLine("Число");
int N = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= N; i++)
{
    Console.WriteLine(i*i*i);
}