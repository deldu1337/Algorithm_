namespace _20250911_Add
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add(1, 1);
        }

        static void Add(int Y, int X)
        {
            int[,] map =
            {
                {1,1,1 },
                {1,1,1 },
                {1,1,1}
            };

            int[] deltaY = { -1, 0, 1, 0 };
            int[] deltaX = { 0, 1, 0, -1 };

            for (int i = 0; i < 4; i++)
            {
                int nY = Y + deltaY[i];
                int nX = X + deltaX[i];
                if(nY < 0 || nY >= map.GetLength(0) || nX < 0 || nX >= map.GetLength(1))
                    continue;
                map[nY, nX]++;
            }

            for (int i = 0;i<map.GetLength(0);i++)
            {
                for(int j = 0; j< map.GetLength(1);j++)
                    Console.Write(map[i,j] + " ");
                Console.WriteLine();
            }
        }
    }
}
