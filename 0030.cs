static void Main(string[] args)
{
    int sum = 0;
    for (int i = 2; i < 1000000; i++)
    {
        int subsum = 0;
        foreach (char c in i.ToString()) subsum += (int)Math.Pow(c - '0', 5);
        if (subsum == i) sum += subsum;
    }
    Console.WriteLine(sum);
}
