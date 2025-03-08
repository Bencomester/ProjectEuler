static void Main(string[] args)
{
    int lych = 0;
    for (int i = 1; i < 10000; i++)
    {
        string str = i.ToString();
        string rev = reverse(str);

        for (int j = 0; j < 50; j++)
        {
            str = addstr(str, rev);
            rev = reverse(str);
            if (str == rev) break;
        }
        if (str != rev) lych++;
    }
    Console.WriteLine(lych);
}

static string reverse(string str)
{
    string rev = "";
    foreach (char c in str) rev = c + rev;
    return rev;
}

static string addstr(string str1, string str2)
{
    string sum = "";
    int remainder = 0;
    if (str1.Length < str2.Length)
    {
        int j = str2.Length - str1.Length;
        for (int i = 0; i < j; i++)
        {
            str1 = "0" + str1;
        }
    }
    else if (str1.Length > str2.Length)
    {
        int j = str1.Length - str2.Length;
        for (int i = 0; i < j; i++)
        {
            str2 = "0" + str2;
        }
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
