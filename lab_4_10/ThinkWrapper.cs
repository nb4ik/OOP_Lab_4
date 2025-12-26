using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_10
{
    public class ThinkWrapper
    {
        private string[] _think;
        private int _count;

        public ThinkWrapper(int initialCapacity = 10)
        {
            _think = new string[initialCapacity];
            _count = 0;
        }

        public void Add(string think)
        {
            if (_count == _think.Length)
            {
                Array.Resize(ref _think, _think.Length * 2);
            }
            _think[_count] = think;
            _count++;
        }

        public int Count => _count;

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                {
                    throw new IndexOutOfRangeException("Индекс выходит за пределы массива.");
                }
                return _think[index];
            }
            set
            {
                if (index < 0 || index >= _count)
                {
                    throw new IndexOutOfRangeException("Индекс выходит за пределы массива.");
                }
                _think[index] = value;
            }
        }
    }
}
