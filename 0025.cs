static void Main(string[] args)
{
    string[] fib = new string[3];
    fib[0] = "1"; fib[1] = "2";
    ulong index = 2;

    while (true)
    {
        if (fib[0].Length == 1000) break;
        fib[2] = addstr(fib[0], fib[1]); fib[0] = fib[1]; fib[1] = fib[2]; index++;
    }
    Console.WriteLine(index);
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
