namespace MonthCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MonthsCollection monthsOfYear = new MonthsCollection();
            var months = monthsOfYear.GetMonthsWithSuchNumberOfDays(30);
            foreach ( var month in months )
            {
                Console.WriteLine(month);
            }
            Console.WriteLine(monthsOfYear.GetNumberOfDaysInMonth("February"));
            Console.WriteLine(monthsOfYear["December"]);
        }
    }
}
