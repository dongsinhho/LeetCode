namespace CombinationSum
{
    public class Program
    {
        public static void Main()
        {
            int[] data = new int[] { 8, 6, 2, 5, 4, 8, 3, 7 };
            IList<IList<int>> x = CombinationSum(data, 11);
            foreach (var i in x) {
                Console.WriteLine(String.Join(", ", i));
            }

        }
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(candidates);
            FindList(candidates, 0, target, new List<int>(), result);
            return result;
        }

        public static void FindList(int[] candidates, int position, int target, List<int> current, IList<IList<int>> result)
        {
            if (target < 0)
            {
                return;
            }
            if (target == 0)
            {
                result.Add(new List<int>(current));
                return;
            }
            for (int i = position; i < candidates.Length; i++)
            {
                current.Add(candidates[i]);
                FindList(candidates, i, target - candidates[i], current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}