using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Assignment01_ADV
{
    internal class Range<T> where T : IComparable<T> ,INumber<T>
    {
        public T Max {  get; set; }

        public T Min { get; set; }
        public Range(T max, T min) 
        { 
            Max = max;
            Min = min;
        }
        public bool IsInRange(T Value) 
        {
            return Value.CompareTo(Min) >= 0 && Value.CompareTo(Max) <= 0;
        }

        public T Length() 
        {
            return T.Abs( Max - Min );
        }

        public override string ToString()
        {
            return $"[{Max} - {Min}]";
        }
    }
}
