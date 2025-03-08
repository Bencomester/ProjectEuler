static void Main(string[] args)
{
    List<int> chain = new List<int>();
    int sum = 0;
    for (int i = 0; i < 1000000; i++)
    {
        int n = i;
        while (!chain.Contains(n))
        {
            chain.Add(n);
            n = digitFact(n);
        }
        if (chain.Count == 60) sum++;
        chain.Clear();
    }
    Console.WriteLine(sum);
}

static int factorial(int i)
{
    if (i <= 1) return 1;
    return i * factorial(i - 1);
}

static int digitFact(int i)
{
    int n = 0;
    while (i > 0)
    {
        n += factorial(i % 10);
        i /= 10;
    }
    return n;
}
