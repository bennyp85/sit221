using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Week03
{
    public class IntDescendingComparer : IComparer<int>
    {
        public int Compare(int A, int B)
        {
            return -1 * Math.Sign(A - B);
        }
    }
}