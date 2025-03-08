static void Main(string[] args)
{
    int max = 0;
    HashSet<int> primes = new HashSet<int>();
    for (int i = 2; i <= 7654321; i++)
    {
        if (!isPrime(i, ref primes)) continue;
        primes.Add(i);

        if (pandigital(i.ToString()) && i > max) max = i;
    }
    Console.WriteLine(max);
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

static bool pandigital(string str)
{
    if (str.Contains("0")) return false;
    HashSet<char> digits = str.ToCharArray().ToHashSet();
    if (digits.Count != str.Length) return false;
    if (Array.ConvertAll(str.ToCharArray(), s => s - '0').Max() != str.Length) return false;
    return true;
}
