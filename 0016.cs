static void Main(string[] args)
{
    int sum = 0;
    foreach (char i in twoToThePowerOf(1000)) sum += i - '0';
    Console.WriteLine(sum);
}

static string twoToThePowerOf(int n)
{
    string current = "1";
    for (int i = 0; i < n; i++) current = addstr(current, current);
    return current;
}

static string addstr(string str1, string str2)
{
    string sum = "";
    int remainder = 0;
    if (str1.Length < str2.Length)
    {
        int j = str2.Length - str1.Length;
        for (int i = 0; i < j; i++) str1 = "0" + str1;
    }
    else if (str1.Length > str2.Length)
    {
        int j = str1.Length - str2.Length;
        for (int i = 0; i < j; i++) str2 = "0" + str2;
    }

    for (int i = str1.Length; i > 0; i--)
    {
        int subsum = str1[i - 1] - '0' + str2[i - 1] - '0' + remainder;
        remainder = 0;
        if (subsum > 9) remainder = subsum / 10;
        sum = (subsum % 10) + sum;
    }
    if (remainder != 0) sum = remainder + sum;

    return sum;
}
