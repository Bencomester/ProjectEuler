static void Main(string[] args)
{
    for (ulong i = 1; true; i++)
    {
        if (!sameDigAs(i, 2 * i)) continue;
        if (!sameDigAs(i, 3 * i)) continue;
        if (!sameDigAs(i, 4 * i)) continue;
        if (!sameDigAs(i, 5 * i)) continue;
        if (!sameDigAs(i, 6 * i)) continue;
        Console.WriteLine(i);
        break;
    }
}

static bool sameDigAs(ulong a, ulong b)
{
    Dictionary<char, int> nums = new Dictionary<char, int>();
    nums.Add('0', 0);
    nums.Add('1', 0);
    nums.Add('2', 0);
    nums.Add('3', 0);
    nums.Add('4', 0);
    nums.Add('5', 0);
    nums.Add('6', 0);
    nums.Add('7', 0);
    nums.Add('8', 0);
    nums.Add('9', 0);
    foreach (char i in a.ToString()) nums[i]++;
    foreach (char i in b.ToString()) nums[i]--;
    return nums.Values.Sum() == 0 && nums.Values.Max() == 0;
}
