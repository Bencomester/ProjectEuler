static void Main(string[] args)
{
    List<int> primes = primesUntil(10000);
    int sum = 0;
    for (int i = 2; i < 10000; i++)
    {
        if (primes.Contains(i)) continue;
        int j = properDivisors(i, ref primes).Sum() - i;
        if (j < 10000 && i == properDivisors(j, ref primes).Sum() - j && i != j)
        {
            sum += i;
            sum += j;
        }
    }
    Console.WriteLine(sum / 2);
}

static List<int> primesUntil(int n)
{
    List<int> primes = new List<int>();
    primes.Add(2);
    for (int i = 2; i < n; i++)
    {
        if (prime(i, ref primes)) primes.Add(i);
    }
    return primes;
}

static bool prime(int n, ref List<int> primes)
{
    foreach (int j in primes)
    {
        if (j * j > n) break;
        if (n % j == 0) return false;
    }
    return true;
}

static Dictionary<int, int> primeFactors(int n, ref List<int> primes)
{
    Dictionary<int, int> pf = new Dictionary<int, int>();
    foreach (int i in primes)
    {
        if (n == 1) break;
        while (n % i == 0)
        {
            n /= i;
            if (pf.ContainsKey(i)) pf[i]++;
            else pf.Add(i, 1);
        }
    }
    return pf;
}

static int[] properDivisors(int n, ref List<int> primes)
{
    if (primes.Contains(n)) return new[] { n, 1 };
    HashSet<int> f = new HashSet<int>();
    Dictionary<int, int> pf = primeFactors(n, ref primes);
    Dictionary<int, int> current = new Dictionary<int, int>();
    foreach (int i in pf.Keys) current.Add(i, 0);

    int cKey = 0;
    while (pf != current)
    {
        int c = 1;
        foreach (int i in current.Keys) c *= (int)Math.Pow(i, current[i]);
        f.Add(c);
        if (current[pf.Keys.ElementAt(cKey)] == pf[pf.Keys.ElementAt(cKey)])
        {
            while (current[pf.Keys.ElementAt(cKey)] == pf[pf.Keys.ElementAt(cKey)])
            {
                if (pf.Keys.ElementAt(cKey) == pf.Keys.Last()) break;
                cKey++;
            }
            if (pf.Keys.ElementAt(cKey) == pf.Keys.Last() && current[pf.Keys.ElementAt(cKey)] == pf[pf.Keys.ElementAt(cKey)]) break;
            current[pf.Keys.ElementAt(cKey)]++;
            for (int i = 0; i < cKey; i++) current[pf.Keys.ElementAt(i)] = 0;
            cKey = 0;
        }
        else current[pf.Keys.ElementAt(cKey)]++;
    }

    return f.ToArray();
}
