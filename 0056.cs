static void Main(string[] args)
{
    int max = 0;
    for (int i = 2; i < 100; i++)
    {
        for (int j = 2; j < 100; j++)
        {
            string pow = quickPow(i, j);
            int sum = Array.ConvertAll(pow.ToCharArray(), c => c - '0').Sum();
            if (sum > max) max = sum;
        }
    }
    Console.WriteLine(max);
}

static string quickPow(int a, int b)
{
    List<ulong> nums = new List<ulong>();
    ulong n = 1;
    for (int i = 0; i < b; i++)
    {
        if (n < 184467440737095516) n *= (ulong)a;
        else
        {
            nums.Add(n);
            n = (ulong)a;
        }
    }
    nums.Add(n);
    string sum = "1";
    foreach (ulong i in nums) sum = stringTimesUlong(sum, i);
    return sum;
}

static string stringTimesUlong(string s, ulong n)
{
    string sum = "0";
    for (int i = 1; i <= s.Length; i++)
    {
        sum = addstr((ulong)(s[s.Length - i] - '0') * n + new string('0', i - 1), sum);
    }
    return sum;
}
