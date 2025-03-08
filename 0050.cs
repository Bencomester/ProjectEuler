static void Main(string[] args)
{
    Dictionary<int, int> sums = new Dictionary<int, int>();
    int[] primes = primesUntil(1000000).ToArray();
    for (int i = 0; i < primes.Length; i++)
    {
        int sum = primes[i];
        for (int j = i + 1; j < primes.Length; j++)
        {
            sum += primes[j];
            if (sum > 1000000) break;
            if (primes.Contains(sum))
            {
                if (sums.ContainsKey(sum)) { if (sums[sum] < j - i + 1) sums[sum] = j - i + 1; }
                else sums.Add(sum, j - i + 1);
            }
        }
    }
    foreach (int i in sums.Keys)
    {
        if (sums[i] != sums.Values.Max()) continue;
        Console.WriteLine(i);
        break;
    }
}

static List<int> primesUntil(int n)
{
    List<int> primes = new List<int>();
    primes.Add(2);
    for (int i = 2; i < n; i++) if (prime(i, ref primes)) primes.Add(i);
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
