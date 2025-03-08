static void Main(string[] args)
{
    int maxNum = 0;
    int maxLen = 0;
    for (int i = 2; i < 1000; i++)
    {
        HashSet<int> remainders = new HashSet<int>();
        remainders.Add(0);
        int remainder = 1;
        string nums = "";

        while (!remainders.Contains(remainder))
        {
            remainders.Add(remainder);
            nums += (remainder * 10 / i).ToString();
            remainder = remainder * 10 % i;
        }
        int len = fracLen(nums, remainder, i);
        if (len > maxLen) { maxLen = len; maxNum = i; }
    }
    Console.WriteLine(maxNum);
}

static int fracLen(string nums, int r, int i)
{
    for (int j = 0; j < nums.Length; j++)
    {
        if (int.Parse(nums[j].ToString()) == r * 10 / i) return nums.Length - j;
    }
    return 0;
}
