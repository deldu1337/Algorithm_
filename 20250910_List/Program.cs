namespace _20250910_List
{
    class MyList<T>
    {
        public int count = 0;
        public int capacity { get { return data.Length; } }
        public T[] data;

        public MyList()
        {
            data = new T[1];
        }

        public T this[int index]
        {
            get
            {
                if (index >= count)
                    throw new ArgumentOutOfRangeException(nameof(index));
                return data[index];
            }
            set
            {
                if (index >= count)
                    throw new ArgumentOutOfRangeException(nameof(index));
                data[index] = value;
            }
        }

        public void AddLast(T item)
        {
            if (count >= capacity)
            {
                int newCapacity = count == 0 ? 1 : capacity * 2;
                T[] temp = new T[newCapacity];
                for(int i = 0; i < count; i++)
                    temp[i] = data[i];
                data = temp;
            }
            data[count++] = item;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < count; i++)
                data[i] = data[i + 1];
            count--;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.AddLast(1);
            myList.AddLast(2);
            myList.AddLast(3);
            myList.RemoveAt(1);

            Console.WriteLine(myList[0]);
            Console.WriteLine(myList[1]);
        }
    }
}
