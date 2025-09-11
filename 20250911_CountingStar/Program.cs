namespace _20250911_CountingStar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountingStar("abc");
        }

        static void CountingStar(string s)
        {
            int[] result = new int[26];
            foreach (int a in s)
            {
                result[a - 'a']++;
            }

            foreach (int a in result)
                Console.Write($"{a} ");
        }
    }
}
