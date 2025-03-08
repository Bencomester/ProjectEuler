static void Main(string[] args)
{
    ulong num = 1;
    ulong fact = 2;
    for (ulong i = 21; i <= 40; i++)
    {
        num *= i;
        if (num % fact == 0) num /= fact++;
    }

    Console.WriteLine(num);
}

