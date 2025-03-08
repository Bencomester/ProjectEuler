static void Main(string[] args)
{
    int max = 0;
    for (int i = 2; i < 100000; i++)
    {
        if (i % 1000000 == 0) Console.WriteLine(i);
        List<int> num = new List<int>();
        num.Add(1);
        for (int j = 2; j < 4; j++)
        {
            if (i.ToString().Length * j > 9) break;
            num.Add(j);
            int n = concatenate(i, num.ToArray());
            max = pandig(n) && n > max ? n : max;
        }
    }
    Console.WriteLine(max);
}

static bool pandig(int n)
{
    HashSet<int> set = new HashSet<int>();
    if (n.ToString().Contains("0")) return false;
    while (n > 0)
    {
        set.Add(n % 10);
        n /= 10;
    }
    return set.Count == 9;
}

static int concatenate(int n, int[] t)
{
    string product = "";
    foreach (int i in t) product += (n * i).ToString();
    return product.Length > 9 ? 0 : int.Parse(product);
}
