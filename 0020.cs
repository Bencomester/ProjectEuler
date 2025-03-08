static void Main(string[] args)
{
    int two = 0;
    int[] nums = new int[100];

    for (int i = 1; i <= 100; i++)
    {
        int n = i;
        while (n % 2 == 0)
        {
            n = n / 2;
            two++;
        }
        while (n % 5 == 0)
        {
            n = n / 5;
            two--;
        }
        nums[i - 1] = n;
    }

    string num = "1";

    for (int i = 0; i < 100; i++) num = stringTimesInt(num, nums[i]);
    for (int i = 0; i < two; i++) num = stringTimesInt(num, 2);
    int sum = 0;
    foreach (char i in num.ToString()) sum += i - '0';
    Console.WriteLine(sum);
}

static string stringTimesInt(string s, int n)
{
    string sum = "0";
    for (int i = 1; i <= s.Length; i++)
    {
        sum = addstr((s[s.Length - i] - '0') * n + new string('0', i - 1), sum);
    }
    return sum;
}
