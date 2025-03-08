static void Main(string[] args)
{
    int cons = 0;
    HashSet<int> primes = new HashSet<int>();
    for (int i = 1; i < 1000000; i++)
    {
        if (fourDistinctFactors(i, ref primes)) cons++; else cons = 0;
        if (cons != 4) continue;
        Console.WriteLine(i - 3);
        break;
    }
}

static bool fourDistinctFactors(int n, ref HashSet<int> primes)
{
    HashSet<int> primeFactors = new HashSet<int>();
    for (int i = 2; i * i <= n; i++)
    {
        if (!isPrime(i, ref primes)) continue;
        if (n % i == 0) primeFactors.Add(i);
        while (n % i == 0) n /= i;
        if (primeFactors.Count > 4) return false;
    }
    if (n > 1) primeFactors.Add(n);
    return primeFactors.Count == 4;
}

static bool isPrime(int n, ref HashSet<int> primes)
{
    if (primes.Contains(n)) return true;
    if (primes.Count == 0) return true;
    foreach (int i in primes)
    {
        if (i * i > n) break;
        if (n % i == 0) return false;
    }
    primes.Add(n);
    return true;
}
