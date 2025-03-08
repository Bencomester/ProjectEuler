static void Main(string[] args)
{
    int sum = 0;
    for (int i = 10; i < 9999999; i++)
    {
        sum += isSumOfDigitFacts(i) ? i : 0;
    }
    Console.WriteLine(sum);
}

static int factorial(int i)
{
    return i <= 1 ? 1 : i * factorial(i - 1);
}

static bool isSumOfDigitFacts(int i)
{
    int sum = 0;
    foreach (char c in i.ToString()) sum += factorial(c - '0');
    return sum == i;
}
