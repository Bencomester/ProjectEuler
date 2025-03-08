static void Main(string[] args)
{
    ulong sum = 28433;
    for (int i = 0; i < 7830457; i++)
    {
        sum *= 2;
        sum %= 10000000000;
    }
    Console.WriteLine(++sum);
}
