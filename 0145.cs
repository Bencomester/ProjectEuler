static void Main(string[] args)
{
    ulong count = 0;
    for (ulong i = 1; i < 1000000000; i++) if (reversible(i)) count++;
    Console.WriteLine($"Result: {2 * count}");
}

static bool reversible(ulong n)
{
    if (n % 10000000 == 0) Console.WriteLine($"Progress: {(double)n / 1000000000: 00%}");
    if (n % 10 == 0) return false;
    ulong rev = reverse(n);
    if (n > rev) return false;
    ulong sum = n + rev;
    while (sum > 0)
    {
        if (sum % 2 == 0) return false;
        sum /= 10;
    }
    return true;
}

static ulong reverse(ulong n)
{
    ulong rev = 0;
    while (n > 0)
    {
        rev *= 10;
        rev += n % 10;
        n /= 10;
    }
    return rev;
}
