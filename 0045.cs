static void Main(string[] args)
{
    HashSet<ulong> t = new HashSet<ulong>();
    HashSet<ulong> p = new HashSet<ulong>();
    HashSet<ulong> h = new HashSet<ulong>();
    for (ulong i = 1; true; i++)
    {
        ulong j = i * (i + 1) / 2;
        t.Add(j);
        p.Add(i * (3 * i - 1) / 2);
        h.Add(i * (2 * i - 1));
        if (j == 1 || j == 40755) continue;
        if (p.Contains(j) && h.Contains(j))
        {
            Console.WriteLine(j);
            break;
        }
    }
}
