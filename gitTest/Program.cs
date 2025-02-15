
namespace gitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            double average = ints.Average();
            List<int> result = NumbersGreaterThanAvrg(ints, average);

            result.Sort();
            result.Reverse();

            List<int> finalResult = result.Take(5).ToList();

            if (finalResult.Count == 0) // Поправена проверка
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", finalResult));
            }
        } 

        static List<int> NumbersGreaterThanAvrg(List<int> ints, double average)
        {
            List<int> result = new List<int>();

            foreach (int num in ints)
            {
                if (num > average)
                {
                    result.Add(num);
                }
            }

            return result;
        }
    }
}
