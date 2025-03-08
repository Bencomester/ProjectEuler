static void Main(string[] args)
{
    List<ulong> primes = new List<ulong>();
    primes.Add(2);
    for (ulong i = 9; true; i++)
    {
        if (i % 2 == 0) continue;
        bool good = false;
        primesUntil(i, ref primes);
        foreach (ulong j in primes) if (IsPerfectSquare((i - j) / 2) || prime(i, ref primes)) { good = true; break; }
        if (good) continue;
        Console.WriteLine(i);
        break;
    }
}

static void primesUntil(ulong n, ref List<ulong> primes)
{
    for (ulong i = primes.ElementAt(primes.Count - 1) + 1; i < n; i++)
    {
        if (prime(i, ref primes)) primes.Add(i);
    }
}

static bool prime(ulong n, ref List<ulong> primes)
{
    foreach (ulong j in primes)
    {
        if (j * j > n) break;
        if (n % j == 0) return false;
    }
    return true;
}

static bool IsPerfectSquare(ulong input)
{
    ulong closestRoot = (ulong)Math.Sqrt(input);
    return input == closestRoot * closestRoot;
}
