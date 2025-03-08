static void Main(string[] args)
{
    HashSet<int> products = new HashSet<int>();
    for (int i = 1; i <= 9999; i++)
    {
        for (int j = 1; j <= 9999; j++)
        {
            if (j > 999 && i > 99) break;
            int n = i * j;
            if (pandig($"{i}{j}{n}")) products.Add(n);
        }
    }
    Console.WriteLine(products.Sum());
}

static bool pandig(string str)
{
    if (str.Contains("0")) return false;
    if (str.Length > 9) return false;
    HashSet<char> digits = str.ToCharArray().ToHashSet();
    if (digits.Count != 9) return false;
    if (Array.ConvertAll(str.ToCharArray(), s => s - '0').Max() != 9) return false;
    return true;
}
