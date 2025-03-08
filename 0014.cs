static void Main(string[] args)
{
    ulong length = 0;
    ulong colnum = 0;
    for (ulong i = 1; i < 1000000; i++)
    {
        ulong len = collatzLength(i);
        if (len > length)
        {
            length = len;
            colnum = i;
        }
    }
    Console.WriteLine(colnum);
}

static ulong collatzLength(ulong n)
{
    ulong index = 1;
    while (n != 1)
    {
        if (n % 2 == 0) n /= 2;
        else n = 3 * n + 1;
        index++;
    }
    return index;
}
