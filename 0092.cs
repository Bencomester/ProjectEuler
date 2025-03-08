static void Main(string[] args)
{
    int sum = 0;
    for (int i = 0; i < 10000000; i++) if (stuckAt89(i)) sum++;
    Console.WriteLine(sum);
}

static bool stuckAt89(int i)
{
    while (i > 1) if (i == 89) return true; else i = squareSum(i);
    return false;
}

static int squareSum(int i)
{
    int sum = 0;
    while (i > 0)
    {
        sum += (i % 10) * (i % 10);
        i /= 10;
    }
    return sum;
}
