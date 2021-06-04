using System;

namespace mylist
{
    class mylist
    {
        private string[] _items = new string[4];

        private int _size = 0;

        public int Count { get; }


        public mylist()
        {
            Count = _size;
        }
        
        public void Add(string item)
        {
            if (_size > _items.Length -1)
            {
                string[] newstring = new string[_items.Length*2];
                Array.Copy(_items, newstring,_items.Length);
                
                _items = newstring;
            }
            _items[_size] = item;
            _size = _size + 1;
        }
        

        public void Getindex(int index){
            try{
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
                Console.WriteLine($"Item {i}) {_items[i]}");
            }
        }
    }
}