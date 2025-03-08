static void Main(string[] args)
{
    int n = 0;
    for (int i = 100; i < 1000; i++)
    {
        for (int j = 100; j < 1000; j++)
        {
            int num = i * j;
            if (palindrome(num) && num > n) n = num;
        }
    }
    Console.WriteLine(n);
}

static bool palindrome(int n)
{
    String str = n.ToString();
    String rev = "";
    for (int i = str.Length; i > 0; i--) rev += str[i - 1];
    return str == rev;
}
