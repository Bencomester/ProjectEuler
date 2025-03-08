static void Main(string[] args)
{
    ulong n = 100;
    ulong sumosq = 0;
    ulong sqosum = 0;

    for (ulong i = 1; i < n + 1; i++)
    {
        sumosq += i * i;
        sqosum += i;
    }
    sqosum *= sqosum;

    Console.WriteLine(sqosum - sumosq);
}
