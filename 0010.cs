static void Main(string[] args)
{
    ulong sum = 0;
    List<ulong> primes = new List<ulong>();
    for (ulong i = 2; i < 2000000; i++)
    {
        if (prime(i, primes))
        {
            primes.Add(i);
            sum += i;
        }
    }
    Console.WriteLine(sum);
}

static bool prime(ulong n, List<ulong> list)
{
    foreach (ulong j in list)
    {
        if (j * j > n) break;
        if (n % j == 0) return false;
    }
    return true;
}
