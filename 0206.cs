static void Main(string[] args)
{
    for (ulong i = 1054092553; i < 1490711985; i++)
    {
        if (i % 10 != 0) continue;
        if (correct((i * i).ToString()))
        {
            Console.WriteLine(i);
            break;
        }
    }
}

static bool correct(string n)
{
    if (n.Length != 19) return false;
    for (int j = 1; j < 11; j++) if (n[(j - 1) * 2] != j.ToString()[j < 10 ? 0 : 1]) return false;
    return true;
}
