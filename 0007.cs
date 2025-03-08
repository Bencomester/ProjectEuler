static void Main(string[] args)
{
    List<ulong> primes = new List<ulong>();
    for (ulong i = 2; primes.Count != 10001; i++)
    {
        if (prime(i, primes.ToArray())) primes.Add(i);
    }
    Console.WriteLine(primes.ElementAt(10000));
}

static bool prime(ulong n, ulong[] t)
{
    foreach (ulong j in t) if (n % j == 0) return false;
    return true;
}
