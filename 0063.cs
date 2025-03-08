static void Main(string[] args)
{
    int count = 0;
    for (int i = 1; true; i++)
    {
        bool found = false;
        for (int j = 1; true; j++)
        {
            BigInteger len = BigInteger.Pow(j, i).ToString().Length;
            if (len == i)
            {
                count++;
                found = true;
            }
            if (len > i) break;
        }
        if (!found) break;
    }
    Console.WriteLine(count);
}
