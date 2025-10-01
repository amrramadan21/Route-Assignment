using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_LINQ02
{
    internal class MatchStringComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            if (x is not null && y is not null)
            {
                string X = string.Concat(x.OrderBy(c => c));
                string Y = string.Concat(y.OrderBy(c => c));

                return Y == X;

            }
            return false;
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            if (obj is not null)
                return new string(obj.OrderBy(c => c).ToArray()).GetHashCode();

            return -1;
        }
    }
}
