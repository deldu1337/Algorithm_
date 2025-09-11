namespace _20250911_arr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,] result = new int[3, 3];

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        result[i,j] = arr[i,j];
                        continue;
                    }
                    if(i == 3  && j == 3)
                    {
                        result[i, j] = arr[i, j];
                        continue;
                    }

                    int temp = arr[i, j];
                    result[i, j] = arr[j, i];
                    result[j,i] = temp;
                }
            }

            for(int i = 0;i < arr.GetLength(0); i++)
            {
                for(int j = 0;j < arr.GetLength(1); j++)
                {
                    Console.Write(result[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
