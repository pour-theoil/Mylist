using System;

namespace mylist
{
    class mylist
    {
        private string[] _items = new string[4];

        private int _size;

        public int Count()
        {
            return _size;
        }


        public void Add(string item)
        {
            if (_size > _items.Length - 1)
            {
                string[] newstring = new string[_items.Length * 2];
                Array.Copy(_items, newstring, _items.Length);

                _items = newstring;
            }
            _items[_size] = item;
            _size = _size + 1;
        }


        public void Getindex(int index)
        {
            try
            {
                string value = _items[index];
                Console.WriteLine($"The value at index {index} is {value} ");
            }
            catch
            {
                Console.WriteLine("out of range");
            }
        }

        public void PrintAll()
        {
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine($"Item {i + 1}) {_items[i]}");
            }
        }

        public void Clear()
        {
            for (int p = 0; p < _items.Length; p++)
            {
                _items[p] = "";
            }
        }

        public void RemoveIndex(int index)
        {

            Array.Copy(_items, index, _items, index - 1, _size - index);
            _size--;
        }

        public void Insert(int index, string value)
        {

            Console.WriteLine(_items.Length);
            string[] newstring = new string[_items.Length + 1];
            Array.Copy(_items, newstring, _items.Length);
            Array.Copy(_items, index, newstring, index + 1, _items.Length - index);
            _items = newstring;
            _items[index] = value;
            _size++;
        }
    }
}