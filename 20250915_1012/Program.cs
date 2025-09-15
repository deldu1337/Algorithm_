namespace _20250915_1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while(t-- > 0)
            {
                string[] arr = Console.ReadLine().Split(" ");
                int result = 0;
                int m = int.Parse(arr[0]);
                int n = int.Parse(arr[1]);
                int k = int.Parse(arr[2]);

                int[,] adj = new int[n, m];
                bool[,] visited = new bool[n, m];

                for (int i = 0; i < k; i++)
                {
                    string[] s = Console.ReadLine().Split(" ");
                    adj[int.Parse(s[1]), int.Parse(s[0])] = 1;
                }

                for (int i = 0; i < n; i++)
                {
                    for(int j = 0; j < m; j++)
                    {
                        if (adj[i, j] == 1 && !visited[i,j])
                        {
                            DFS(i, j, adj, visited);
                            result++;
                        }
                    }
                }
                Console.WriteLine(result);
            }
        }

        static public void DFS(int a, int b, int[,] adj, bool[,] visited)
        {
            visited[a,b] = true;
            int[] deltaY = { -1, 0, 1, 0 };
            int[] deltaX = { 0, 1, 0, -1 };

            for (int i = 0; i< 4;i++)
            {
                int DY = a + deltaY[i];
                int DX = b + deltaX[i];

                if(DY < 0 || DY >= adj.GetLength(0) || DX < 0 || DX >= adj.GetLength(1))
                    continue;
                if (adj[DY,DX] == 0)
                    continue;
                if (visited[DY, DX])
                    continue;
                DFS(DY, DX, adj, visited);
            }
        }
    }
}
