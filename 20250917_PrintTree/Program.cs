namespace _20250917_pointTree
{
    class TreeNode<T>
    {
        public T Data { get; set; }                    // 노드의 데이터
        public List<TreeNode<T>> Children { get; set; } = new List<TreeNode<T>>(); // 자식 노드 리스트
    }

    internal class Program
    {
        static TreeNode<string> MakeTree()
        {
            TreeNode<string> root = new TreeNode<string>() { Data = "A" };

            TreeNode<string> nodeB = new TreeNode<string>() { Data = "B" };
            TreeNode<string> nodeD = new TreeNode<string>() { Data = "D" };
            nodeD.Children.Add(new TreeNode<string>() { Data = "H" });
            nodeD.Children.Add(new TreeNode<string>() { Data = "I" });
            TreeNode<string> nodeE = new TreeNode<string>() { Data = "E" };
            nodeB.Children.Add(nodeD);
            nodeB.Children.Add(nodeE);

            TreeNode<string> nodeC = new TreeNode<string>() { Data = "C" };
            nodeC.Children.Add(new TreeNode<string>() { Data = "F" });
            nodeC.Children.Add(new TreeNode<string>() { Data = "G" });

            root.Children.Add(nodeB);
            root.Children.Add(nodeC);

            return root;
        }

        static void PrintTree(TreeNode<string> node)
        {
            Console.WriteLine(node.Data);
            for (int i = 0; i < node.Children.Count; i++)
            {
                PrintTree(node.Children[i]);
            }
        }

        static void Main(string[] args)
        {
            PrintTree(MakeTree());
        }
    }
}
