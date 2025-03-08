static void Main(string[] args)
{
    List<ulong> nums = new List<ulong>();
    ulong step = 1000000;
    List<ulong> primes = new List<ulong>();
    primes.Add(2);
    primesUntil(step, ref primes);
    while (nums.Count < 11)
    {
        primesUntil(step, ref primes);
        step *= 2;
        foreach (ulong i in primes)
        {
            if (i < 10) continue;
            if (nums.Count > 0 && i <= nums.Max()) continue;
            if (trunc(i, ref primes)) nums.Add(i);
            if (nums.Count == 11) break;
        }
    }
    ulong sum = 0;
    foreach (ulong i in nums) sum += i;
    Console.WriteLine(sum);
}

static bool trunc(ulong n, ref List<ulong> primes)
{
    ulong i = n;
    while (n > 10)
    {
        n = n % (ulong)Math.Pow(10, n.ToString().Length - 1);
        if (!primes.Contains(n)) return false;
    }
    n = i;

    while (n > 10)
    {
        n = n / 10;
        if (!primes.Contains(n)) return false;
    }
    return true;
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
