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
                _items.CopyTo(newstring, _items.Length);
                _items = newstring;
            }
            _items[_size] = item;
            _size = _size + 1;
        }
    }
}