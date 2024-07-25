using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced_1.Generic
{
    public class Range<T> where T : IComparable<T>
    {
        private T _min;
        private T _max;

        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
            {
                throw new ArgumentException("Minimum value cannot be greater than maximum value.");
            }

            _min = min;
            _max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(_min) >= 0 && value.CompareTo(_max) <= 0;
        }

        public T Length()
        {
            dynamic min = _min;
            dynamic max = _max;
            return max - min;
        }
    }
}
