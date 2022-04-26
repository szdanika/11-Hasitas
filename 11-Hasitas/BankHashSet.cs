using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Hasitas
{
    internal class BankHashSet<K,T>
    {
        private List<BankHashItem>[] _contents;
        private int _size;
        private HashCallBack HashFunction;

        public delegate int HashCallBack(K key, int size);
        public class BankHashItem
        {
            public K key { get; set; }
            public T content { get; set; }

        }
        private static int DefaultHashing(K key, int size)
        {
            return Math.Abs(key.GetHashCode()) % size;
        }
        public BankHashSet(int size, HashCallBack fg)
        {
            _size = size;
            _contents = new List<BankHashItem>[_size];
            if (fg == null)
                HashFunction = DefaultHashing;
            else
                HashFunction = fg;
        }
        public BankHashSet()
        {
            _size = 100;
            HashFunction = DefaultHashing;
            _contents = new List<BankHashItem>[_size];
        }

        public void Insert(K key, T content)
        {
            int index = HashFunction(key, _size);
            BankHashItem e = new BankHashItem()
            {
                key = key,
                content = content
            };
            _contents[index].Add(e);
            
        }
        public T Find(K key)
        {
            int index = HashFunction(key, _size);
            if (_contents[index] == null)
                throw new DivideByZeroException();
            else
            {
                foreach(var item in _contents[index])
                {
                    if( item.key.Equals(key))
                        return item.content;
                }
            }
            throw new DivideByZeroException(); // exception csin
        }
        public T this[K kulcs]
        {
            get
            {
                return Find(kulcs);
            }
            set
            {
                Insert(kulcs, value);
            }
        }
    }
}
