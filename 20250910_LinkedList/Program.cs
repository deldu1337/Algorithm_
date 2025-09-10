namespace _20250910_LinkedList
{
    class Node<T>
    {
        public Node<T> Next;
        public Node<T> Prev;
        public T data;
    }
    class MyLinkedList<T>
    {
        public Node<T> Head = null;
        public Node<T> Tail = null;
        public int count = 0;

        public Node<T> Add(T item)
        {
            Node<T> newNode = new Node<T>();
            newNode.data = item;
            if(Head == null)
                Head = newNode;
            if(Tail != null)
            {
                Tail.Next = newNode;
                newNode.Prev = Tail;
            }
            Tail = newNode;
            count++;
            return newNode;
        }

        public void Remove(Node<T> node)
        {
            if (Head == node)
                Head = Head.Next;
            if(Tail == node)
                Tail = Tail.Prev;
            if(node.Prev != null)
                (node.Prev).Next = node.Next;
            if (node.Next != null)
                (node.Next).Prev = node.Prev;
            count--;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> myLinkedList = new MyLinkedList<int>();
            myLinkedList.Add(1);
            Node<int> node = myLinkedList.Add(2);
            myLinkedList.Add(3);
            myLinkedList.Remove(node);

            Console.WriteLine(myLinkedList.Head.data);
            Console.WriteLine(myLinkedList.Head.Next.data);
        }
    }
}
