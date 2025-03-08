static void Main(string[] args)
{
    Dictionary<int, int> prim = new Dictionary<int, int>();

    for (int i = 1; i < 21; i++)
    {
        int[] fact = primeFactors(i);
        foreach (int j in fact)
        {
            int count = fact.Where(num => num == j).Count();
            if (!prim.ContainsKey(j)) prim.Add(j, count);
            else if (prim[j] < count) prim[j] = count;
        }
    }

    int sol = 1;
    foreach (int i in prim.Keys)
    {
        sol = sol * (int)Math.Pow(i, prim[i]);
    }
    Console.WriteLine(sol);
}

static int[] primeFactors(int n)
{
    List<int> primes = new List<int>();
    List<int> primeFactors = new List<int>();
    for (int i = 2; 1 < n; i++)
    {
        if (!prime(i, primes.ToArray())) continue;
        primes.Add(i);
        while (n % i == 0)
        {
            n /= i;
            primeFactors.Add(i);
        }
    }
    return primeFactors.ToArray();
}

static bool prime(int n, int[] t)
{
    foreach (int j in t) if (n % j == 0) return false;
    //Console.WriteLine(n);
    return true;
}
