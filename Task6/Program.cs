namespace Task6
{
    internal class Program
    {
        static IEnumerable<int> GetSquaresOfOddNumbers(int[] array)
        {
            foreach (var i in array)
            {
                if (i % 2 != 0)
                {
                    yield return i * i;
                }
            }
            yield break;
        }

        static void Main(string[] args)
        {
            List<int> numbers = GetSquaresOfOddNumbers(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }).ToList();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
