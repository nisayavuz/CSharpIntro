namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("İstanbul");
            sehirler.Add("İstanbul");

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İstanbul");
            sehirler2.Add("Trabzon");
            sehirler2.Add("Ankara");
            sehirler2.Add("İstanbul");

        }
    }

    class MyList<T>
    {
        T[] _array;
        private T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }


        public int Count
        {
            get { return _array.Length; }
        }
    }
}