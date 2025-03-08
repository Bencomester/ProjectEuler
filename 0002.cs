static void Main(string[] args)
{
    ulong[] fib = new ulong[3];
    fib[0] = 1; fib[1] = 2;
    ulong sum = 0;

    while (fib[0] <= 4000000)
    {
        if (fib[0] % 2 == 0) sum += fib[0];
        fib[2] = fib[0] + fib[1];
        fib[0] = fib[1];
        fib[1] = fib[2];
    }
    Console.WriteLine(sum);
}
