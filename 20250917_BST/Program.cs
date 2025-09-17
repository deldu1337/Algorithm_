namespace _20250917_BST
{
    class BSTNode
    {
        public int Key;
        public BSTNode Left;
        public BSTNode Right;

        public BSTNode(int key)
        {
            this.Key = key;
        }
    }

    class BinarySearchTree
    {
        private BSTNode _root;

        public void Insert(int key)
        {
            _root = InsertRec(_root, key);
        }

        public BSTNode InsertRec(BSTNode node, int key)
        {
            if(node == null)
                return new BSTNode(key);
            if(key < node.Key)
                node.Left = InsertRec(node.Left, key);
            if(key > node.Key)
                node.Right = InsertRec(node.Right, key);

            return node;
        }

        public bool Contains(int key)
        {
            // 루트부터 시작해서 순회 하기

            // 지금 이 노드가 니가 찾는 노드 맞음?
            // 맞으면 찾았다!

            // 아니면 왼쪽 오른쪽 비교 


            // 전부 다했는데 못찾았다 그럼 없음
            var node = _root;
            while (node != null)
            {
                if(node.Key == key)
                    return true;
                if(node.Key > key)
                    node = node.Left;
                else if(node.Key < key)
                    node = node.Right;
            }
            return false;
        }

        public void Remove(int key)
        {
            _root = RemoveRec(_root, key);
        }

        public BSTNode RemoveRec(BSTNode node, int key)
        {
            // 삭제하려는 노드가 널일때

            // 삭제하려는 키가 현재 노드보다 작다면
            // 삭제하려는 키가 현재 노드보다 크다면
            // 모두가 아니라면 == 즉 현재 노드가 삭제하려는 노드라면
            // 자식 없는 노드라면
            // 자식이 1개 있는 노드라면
            // 자식이 2개 있는 노드라면
            if (node == null)
                return null;
            if (key < node.Key)
                node = RemoveRec(node.Left, key);
            else if (key > node.Key)
                node = RemoveRec(node.Right, key);
            else
            {
                if (node.Left == null && node.Right == null)
                    return null;
                if (node.Left == null)
                    return node.Right;
                if (node.Right == null)
                    return node.Left;

                // case 3: 자식 2개
                BSTNode min = FindMin(node.Right);
                node.Key = min.Key;
                node.Right = RemoveRec(node.Right, min.Key);

            }
            return node;
        }
        private BSTNode FindMin(BSTNode node)
        {
            while (node.Left != null)
                node = node.Left;
            return node;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var bst = new BinarySearchTree();
            int[] data = { 16, 14, 78, 31, 87, 90 };
            foreach(int i in data)
            {
                bst.Insert(i);
            }
            bst.Remove(16);

            Console.WriteLine(bst.Contains(78));
        }
    }
}
