static void Main(string[] args)
{
    int[,] spiral = new int[1001, 1001];
    fillSpiral(ref spiral);
    int sum = 0;
    for (int i = 0; i < 1001; i++)
    {
        sum += spiral[i, i];
        sum += spiral[i, 1000 - i];
    }
    Console.WriteLine(sum - 1);
}

static void fillSpiral(ref int[,] s)
{
    int num = 2;
    int x = 500;
    int y = 500;
    s[x, y] = 1;
    int move = 1;

    while (num < 1002002)
    {
        for (int i = 0; i < move; i++)
        {
            if (num == 1002002) break;
            x++;
            s[x, y] = num++;
        }
        for (int i = 0; i < move; i++)
        {
            if (num == 1002002) break;
            y--;
            s[x, y] = num++;
        }
        move++;
        for (int i = 0; i < move; i++)
        {
            if (num == 1002002) break;
            x--;
            s[x, y] = num++;
        }
        for (int i = 0; i < move; i++)
        {
            if (num == 1002002) break;
            y++;
            s[x, y] = num++;
        }
        move++;
    }
}
