using System;
using System.Collections;
using System.Collections.Generic;

namespace mylist
{
public class MyList<T> : IList<T>
    {
        private T[] _items = new T[4];

        private int _size;

        public MyList()
        {
        }

        int ICollection<T>.Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        T IList<T>.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

// propertry
        public int Count()
        {
            return _size;
        }
        
        public T this[int i] => _items[i];

   public void Indexer(int index, T value)
   {
       
       if(index <0)
       {
           throw new IndexOutOfRangeException($"The index is out of range");
       }
       if (_size > _items.Length - 1)
            {
                T[] newT = new T[_items.Length * 2];
                Array.Copy(_items, newT, _items.Length);

                _items = newT;
            }
            _items[index] = value;
   }

        public void Add(T item)
        {
            if (_size > _items.Length - 1)
            {
                T[] newT = new T[_items.Length * 2];
                Array.Copy(_items, newT, _items.Length);

                _items = newT;
            }
            _items[_size] = item;
            _size = _size + 1;
        }


        public void Getindex(int index)
        {
            try
            {
                T value = _items[index];
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
                _items[p] = default(T);
            }
        }
        

        public void RemoveIndex(int index)
        {

            Array.Copy(_items, index, _items, index - 1, _size - index);
            _size--;
        }

        public void Insert(int index, T value)
        {

            Console.WriteLine(_items.Length);
            T[] newT = new T[_items.Length + 2];
            Array.Copy(_items, newT, _items.Length);
            Array.Copy(_items, index, newT, index + 1, _items.Length - index);
            _items = newT;
            _items[index] = value;
            _size++;
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            Array.Copy(_items, index, _items, index - 1, _size - index);
            _size--;
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Array.Copy(_items, array, _items.Length);
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
            // int index = Array.FindIndex<T>(item);
            // Array.Copy(_items, index, _items, index - 1, _size - index);
            // _size--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private IEnumerable<T> GetEnumerable()
        {
            for(int p = 0; p < _size; p++ )
            {
                yield return _items[p];
            }
        }
    }
}