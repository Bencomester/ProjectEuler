static void Main(string[] args)
{
    HashSet<double> nums = new HashSet<double>();
    for (int i = 2; i <= 100; i++)
    {
        for (int j = 2; j <= 100; j++)
        {
            nums.Add(Math.Pow(i, j));
        }
    }
    Console.WriteLine(nums.Count);
}
