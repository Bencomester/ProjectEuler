static void Main(string[] args)
{
    int sum = 0;
    for (int i = 1; i < 1000000; i++) if (palindrome(i.ToString()) && palindrome(toBin(i))) sum += i;
    Console.WriteLine(sum);
}

static bool palindrome(string str)
{
    char[] rev = str.ToCharArray();
    Array.Reverse(rev);
    if (str[0] == '0') return false;
    if (rev[0] == '0') return false;
    return str == new string(rev);
}

static string toBin(int n)
{
    string bin = "";
    while (n != 0)
    {
        bin = n % 2 + bin;
        n /= 2;
    }
    return bin;
}
