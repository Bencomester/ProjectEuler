static void Main(string[] args)
{
    HashSet<int> primes = new HashSet<int>();
    for (int i = 2; i < 1000000; i++) if (isPrime(i, ref primes)) primes.Add(i);
    int j = 0;
    foreach (int i in primes) if (circular(i, primes)) j++;
    Console.WriteLine(j);
}

static bool isPrime(int n, ref HashSet<int> primes)
{
    if (primes.Count == 0) return true;
    foreach (int i in primes)
    {
        if (i * i > n) break;
        if (n % i == 0) return false;
    }
    return true;
}

static HashSet<int> circle(int n)
{
    HashSet<int> set = new HashSet<int>();
    List<char> l = n.ToString().ToCharArray().ToList();
    for (int i = 0; i < n.ToString().Length; i++)
    {
        set.Add(int.Parse(string.Join("", l)));
        l.Insert(0, l[l.Count - 1]);
        l.RemoveAt(l.Count - 1);
    }
    return set;
}

static bool circular(int n, HashSet<int> primes)
{
    foreach (int i in circle(n)) if (!primes.Contains(i)) return false;
    return true;
}
