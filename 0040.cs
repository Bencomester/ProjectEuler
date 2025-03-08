static void Main(string[] args)
{
    int mult = 1;
    string str = generate();
    for (int i = 0; i < 7; i++) mult *= str[(int)Math.Pow(10, i) - 1] - '0';
    Console.WriteLine(mult);
}

static string generate()
{
    string str = "";
    int i = 1;
    while (str.Length <= 1000000) str += i++.ToString();
    return str;
}
