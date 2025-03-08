static void Main(string[] args)
{
    int numer = 1;
    int denom = 1;

    for (int i = 10; i <= 99; i++)
    {
        for (int j = i + 1; j <= 99; j++)
        {
            if (digitCancel(i, j))
            {
                numer *= i;
                denom *= j;
            }
        }
    }
    Console.WriteLine(denom / gcd(numer, denom));
}

static bool digitCancel(int a, int b)
{
    string i = a.ToString();
    string j = b.ToString();
    foreach (char c in i)
    {
        if (c == '0') continue;
        if (j.Contains(c))
        {
            j = j[j.IndexOf(c) == 0 ? 1 : 0].ToString();
            i = i[i.IndexOf(c) == 0 ? 1 : 0].ToString();
            break;
        }
    }
    if (i == "" || j == "") return false;
    if (a.ToString() == i) return false;
    return (double)a / b == double.Parse(i) / double.Parse(j);
}

static int gcd(int a, int b)
{
    int r = a % b;
    while (r > 0)
    {
        a = b;
        b = r;
        r = a % b;
    }
    return b;
}
