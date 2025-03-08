static void Main(string[] args)
{
    DateTime date = new DateTime(1901, 01, 01);
    DateTime end = new DateTime(2001, 01, 01);
    int sundays = 0;
    while (date < end)
    {
        if (date.DayOfWeek == DayOfWeek.Sunday && date.Day == 1) sundays++;
        date = date.AddDays(1);
    }
    Console.WriteLine(sundays);
}
