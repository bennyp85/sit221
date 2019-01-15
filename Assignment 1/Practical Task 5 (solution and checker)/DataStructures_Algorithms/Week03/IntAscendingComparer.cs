using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Week03
{
    public class IntAscendingComparer : IComparer<int>
    {
        public int Compare(int A, int B)
        {
            return Math.Sign(A - B);
        }
    }
}