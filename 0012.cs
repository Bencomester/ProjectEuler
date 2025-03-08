static void Main(string[] args)
{
    ulong n = 0;
    for (ulong i = 1; true; i++)
    {
        n += i;
        if (divisors(n) <= 500) continue;
        Console.WriteLine(n);
        break;
    }
}

static int divisors(ulong n)
{
    Dictionary<ulong, int> primeFactors = new Dictionary<ulong, int>();
    HashSet<ulong> primes = new HashSet<ulong>();
    int j = 1;
    for (ulong i = 2; 1 < n; i++)
    {
        if (!prime(i, ref primes)) continue;
        primes.Add(i);
        j = 0;
        while (n % i == 0)
        {
            n = n / i;
            j++;
        }
        if (j != 0) primeFactors.Add(i, j);
    }
    j = 1;
    foreach (int i in primeFactors.Values) j *= (i + 1);
    return j;
}

static bool prime(ulong n, ref HashSet<ulong> primes)
{
    foreach (ulong j in primes)
    {
        if (j * j > n) break;
        if (n % j == 0) return false;
    }
    return true;
}
