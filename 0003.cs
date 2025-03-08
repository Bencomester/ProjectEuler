static void Main(string[] args)
{
    ulong n = 600851475143;
    List<ulong> primes = new List<ulong>();
    HashSet<ulong> primeFactors = new HashSet<ulong>();
    for (ulong i = 2; 1 < n; i++)
    {
        if (!prime(i, primes.ToArray())) continue;
        primes.Add(i);
        while (n % i == 0)
        {
            n = n / i;
            primeFactors.Add(i);
        }
    }
    ulong[] factors = primeFactors.ToArray();
    Console.WriteLine(factors[factors.Length - 1]);
}

static bool prime(ulong n, ulong[] t)
{
    foreach (ulong j in t) if (n % j == 0) return false;
    return true;
}
