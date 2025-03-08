static void Main(string[] args)
{
    for (int a = 1; a < 1000; a++)
    {
        if (a == 500) continue;
        int b = (1000 * (a - 500)) / (a - 1000);
        int c = 1000 - a - b;
        if (a * a + b * b == c * c)
        {
            Console.WriteLine(a * b * c);
            break;
        }
    }
}
