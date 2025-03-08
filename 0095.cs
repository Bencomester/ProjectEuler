static void Main(string[] args)
{
    HashSet<int> primes = primesUntil(1000000);
    List<int> chain = new List<int>();
    HashSet<int> deadNums = new HashSet<int>();
    Dictionary<int, int> pfsum = new Dictionary<int, int>();
    int[] maxChain = new int[0];
    int max = 0;
    for (int i = 2; i <= 1000000; i++)
    {
        if (primes.Contains(i)) continue;
        int n = i;
        chain.Clear();
        while (!chain.Contains(n) && n <= 1000000)
        {
            if (primes.Contains(n)) break;
            if (deadNums.Contains(n)) break;
            chain.Add(n);
            if (n == 1) break;
            if (pfsum.ContainsKey(n)) n = pfsum[n];
            else
            {
                int sum = properDivisors(n, ref primes).Sum() - n;
                pfsum.Add(n, sum);
                n = sum;
            }
        }
        if (primes.Contains(n) || n == 1 || n > 1000000)
        {
            deadNums.Add(i);
            deadNums.Add(n);
            continue;
        }
        if (deadNums.Contains(n))
        {
            deadNums.Add(i);
            continue;
        }

        if (chain.Count - chain.IndexOf(n) > max)
        {
            max = chain.Count - chain.IndexOf(n);
            chain.RemoveRange(0, chain.IndexOf(n));
            maxChain = chain.ToArray();
        }
    }

    Console.WriteLine(maxChain.Min());
}

static HashSet<int> primesUntil(int n)
{
    HashSet<int> primes = new HashSet<int>();
    primes.Add(2);
    for (int i = 2; i < n; i++) if (prime(i, ref primes)) primes.Add(i);
    return primes;
}

static bool prime(int n, ref HashSet<int> primes)
{
    foreach (int j in primes)
    {
        if (j * j > n) break;
        if (n % j == 0) return false;
    }
    return true;
}

static Dictionary<int, int> primeFactors(int n, ref HashSet<int> primes)
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

static int[] properDivisors(int n, ref HashSet<int> primes)
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
