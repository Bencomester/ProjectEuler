static void Main(string[] args)
{
    ulong sum = 0;
    for (int i = 1; i <= 1000; i++) sum = (sum + powLast10(i, i)) % 10000000000;
    Console.WriteLine(sum);
}

static ulong powLast10(int a, int b)
{
    ulong n = 1;
    for (int i = 0; i < b; i++)
    {
        n = n * (ulong)a % 10000000000;
    }
    return n;
}
