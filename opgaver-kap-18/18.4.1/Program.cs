class Program
{
    public static void Main(string[] args)
    {
    }
}
    interface IDynArray<T>
    {
        void Append (T element);
        void Insert (int i, T element);
        void Remove (int i);
        void Set (int i, T element);
        //T Get (int i);
        //int GetFill ();
    }


    class DynArray<T> : IDynArray<T>
    {
        T[] data;
        int capacity;
        int fill;

        public DynArray()
        {
        int capacity = 2;
        data = new T[capacity];
        fill = data.Length;
        }
        public void Append (T element)
        {
            fill = fill + 1;
            if(fill > capacity)
            {
                capacity = 2*data.Length;
                T[]newdata = new T[2*data.Length];
                for(int i = 0; i < data.Length; i++)
                {
                    newdata[i] = data[i];
                }
                data = newdata;
            }
            data[fill] = element;
        }
        public void Insert (int i, T element)
        {

        }
        public void Remove (int i)
        {

        }
        public void Set (int i, T element)
        {

        }
//         public T Get (int i)
//         {
//
//         }
//         public int GetFill()
//         {
//
//         }
    }
