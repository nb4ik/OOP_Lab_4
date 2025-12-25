using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_5
{
    public class StudentWrapper
    {
        private Student[] _students;
        private int _count;

        public StudentWrapper(int initialCapacity = 10)
        {
            _students = new Student[initialCapacity];
            _count = 0;
        }

        public void Add(Student student)
        {
            if (_count == _students.Length)
            {
                Array.Resize(ref _students, _students.Length * 2);
            }
            _students[_count] = student;
            _count++;
        }

        public int Count => _count;

        public Student this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                {
                    throw new IndexOutOfRangeException("Индекс выходит за пределы массива.");
                }
                return _students[index];
            }
            set
            {
                if (index < 0 || index >= _count)
                {
                    throw new IndexOutOfRangeException("Индекс выходит за пределы массива.");
                }
                _students[index] = value;
            }
        }
    }
}
